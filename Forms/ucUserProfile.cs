using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;
using OccupancyMonitor.Models;
using OccupancyMonitor.Services;

namespace OccupancyMonitor.Forms
{
    public partial class ucUserProfile : UserControl
    {
        private readonly UserService _service;
        private readonly string _accessToken;
        private readonly Dictionary<int, User> _usersById = new Dictionary<int, User>();
        private readonly Dictionary<int, UserProfile> _profilesById = new Dictionary<int, UserProfile>();
        private List<UserManagementRow> _allRows = new List<UserManagementRow>();
        private List<UserRole> _adminRoles = new List<UserRole>();
        private int? _selectedUserId;
        private bool _isBusy;
        private bool _isSaving;
        private UserFormMode _formMode = UserFormMode.View;

        private enum UserFormMode
        {
            View,
            Add,
            Edit
        }

        public ucUserProfile(UserService service, string accessToken)
        {
            InitializeComponent();
            _service = service ?? throw new ArgumentNullException(nameof(service));
            _accessToken = accessToken;

            txtPassword.UseSystemPasswordChar = true;
            txtUsername.MaxLength = 50;
            txtFirstName.MaxLength = 50;
            txtMiddleName.MaxLength = 50;
            txtLastName.MaxLength = 50;
            txtContactNumber.MaxLength = 20;
            cbStatus.Items.AddRange(new object[] { "ACTIVE", "INACTIVE" });
            cbStatus.SelectedItem = "ACTIVE";

            dgvUserManagement.AutoGenerateColumns = true;
            dgvUserManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvUserManagement.MultiSelect = false;
            dgvUserManagement.ReadOnly = true;
            dgvUserManagement.SelectionChanged += dgvUserManagement_SelectionChanged;
            kryptonTextBox1.TextChanged += FilterControls_Changed;
            kryptonComboBox1.SelectedIndexChanged += FilterControls_Changed;


            UpdateControlStates();
        }

        private async void ucUserProfile_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_accessToken))
            {
                MessageBox.Show("Please log in first.");
                return;
            }

            await RefreshUsersAsync();
        }

        private async System.Threading.Tasks.Task RefreshUsersAsync()
        {
            if (_isBusy) return;
            _isBusy = true;
            UpdateControlStates();
            try
            {
                var users = await _service.GetUsersAsync(_accessToken);
                var profiles = await _service.GetProfilesAsync(_accessToken);
                var roles = await _service.GetRolesAsync(_accessToken);

                _usersById.Clear();
                foreach (var user in users)
                {
                    _usersById[user.user_id] = user;
                }

                _profilesById.Clear();
                foreach (var profile in profiles)
                {
                    _profilesById[profile.user_id] = profile;
                }

                _adminRoles = roles
                    .Where(role => string.Equals(role.role_name, "ADMIN", StringComparison.OrdinalIgnoreCase))
                    .ToList();
                ConfigureRoleControls(roles);

                var roleNames = roles.ToDictionary(role => role.role_id, role => role.role_name);
                _allRows = users.Select(user =>
                {
                    UserProfile profile;
                    _profilesById.TryGetValue(user.user_id, out profile);
                    string roleName;
                    roleNames.TryGetValue(user.role_id, out roleName);
                    return new UserManagementRow
                    {
                        UserId = user.user_id,
                        Username = user.username,
                        FullName = user.full_name,
                        FirstName = profile == null ? string.Empty : profile.first_name,
                        MiddleName = profile == null ? string.Empty : profile.middle_name,
                        LastName = profile == null ? string.Empty : profile.last_name,
                        ContactNumber = profile == null ? string.Empty : profile.contact_number,
                        Role = roleName ?? user.role_id.ToString(),
                        Status = user.status,
                        CreatedAt = user.created_at
                    };
                }).ToList();

                ApplyFilters();
                ResetToDefaultState();
            }
            catch (Exception ex) when (ex is HttpRequestException || ex is JsonException || ex is InvalidOperationException)
            {
                MessageBox.Show(GetApiMessage(ex), "User Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isBusy = false;
                UpdateControlStates();
            }
        }

        private void ConfigureRoleControls(List<UserRole> roles)
        {
            var roleNames = roles.Select(role => role.role_name).Where(name => !string.IsNullOrWhiteSpace(name))
                .Distinct(StringComparer.OrdinalIgnoreCase).OrderBy(name => name).ToList();

            kryptonComboBox1.Items.Clear();
            kryptonComboBox1.Items.Add("All Roles");
            kryptonComboBox1.Items.AddRange(roleNames.Cast<object>().ToArray());
            kryptonComboBox1.SelectedIndex = 0;

            cbRole.DataSource = null;
            cbRole.DisplayMember = "role_name";
            cbRole.ValueMember = "role_id";
            cbRole.DataSource = _adminRoles;
            if (_adminRoles.Count > 0)
            {
                cbRole.SelectedIndex = 0;
            }
        }

        private void ApplyFilters()
        {
            var search = kryptonTextBox1.Text.Trim();
            var roleFilter = kryptonComboBox1.SelectedItem as string;
            var rows = _allRows.Where(row =>
                (string.IsNullOrWhiteSpace(search) ||
                    Contains(row.Username, search) || Contains(row.FullName, search) ||
                    Contains(row.FirstName, search) || Contains(row.MiddleName, search) ||
                    Contains(row.LastName, search) || Contains(row.ContactNumber, search)) &&
                (string.IsNullOrWhiteSpace(roleFilter) || roleFilter == "All Roles" ||
                    string.Equals(row.Role, roleFilter, StringComparison.OrdinalIgnoreCase)))
                .ToList();

            dgvUserManagement.SelectionChanged -= dgvUserManagement_SelectionChanged;
            dgvUserManagement.DataSource = null;
            dgvUserManagement.DataSource = rows;
            ConfigureGridColumns();
            dgvUserManagement.ClearSelection();
            dgvUserManagement.SelectionChanged += dgvUserManagement_SelectionChanged;
        }

        private void ConfigureGridColumns()
        {
            if (dgvUserManagement.Columns.Count == 0) return;
            dgvUserManagement.Columns[nameof(UserManagementRow.UserId)].HeaderText = "ID";
            dgvUserManagement.Columns[nameof(UserManagementRow.FullName)].HeaderText = "Full Name";
            dgvUserManagement.Columns[nameof(UserManagementRow.FirstName)].HeaderText = "First Name";
            dgvUserManagement.Columns[nameof(UserManagementRow.MiddleName)].HeaderText = "Middle Name";
            dgvUserManagement.Columns[nameof(UserManagementRow.LastName)].HeaderText = "Last Name";
            dgvUserManagement.Columns[nameof(UserManagementRow.ContactNumber)].HeaderText = "Contact Number";
            dgvUserManagement.Columns[nameof(UserManagementRow.CreatedAt)].HeaderText = "Created At";
            dgvUserManagement.Columns[nameof(UserManagementRow.CreatedAt)].DefaultCellStyle.Format = "yyyy-MM-dd";
        }

        private static bool Contains(string value, string term)
        {
            return !string.IsNullOrEmpty(value) && value.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private void FilterControls_Changed(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void dgvUserManagement_SelectionChanged(object sender, EventArgs e)
        {
            if (_formMode != UserFormMode.View) return;
            var row = dgvUserManagement.SelectedRows.Count == 0
                ? null
                : dgvUserManagement.SelectedRows[0].DataBoundItem as UserManagementRow;
            if (row == null)
            {
                return;
            }

            User user;
            if (!_usersById.TryGetValue(row.UserId, out user)) return;
            UserProfile profile;
            _profilesById.TryGetValue(row.UserId, out profile);

            _selectedUserId = user.user_id;
            txtUsername.Text = user.username;
            txtFullname.Text = user.full_name;
            txtPassword.Clear();
            txtFirstName.Text = profile == null ? string.Empty : profile.first_name;
            txtMiddleName.Text = profile == null ? string.Empty : profile.middle_name;
            txtLastName.Text = profile == null ? string.Empty : profile.last_name;
            txtContactNumber.Text = profile == null ? string.Empty : profile.contact_number;
            cbRole.SelectedValue = user.role_id;
            var matchingStatus = cbStatus.Items.Cast<object>()
                .FirstOrDefault(item => string.Equals(item.ToString(), user.status, StringComparison.OrdinalIgnoreCase));
            if (matchingStatus == null && !string.IsNullOrWhiteSpace(user.status))
            {
                cbStatus.Items.Add(user.status);
                matchingStatus = user.status;
            }
            cbStatus.SelectedItem = matchingStatus;
            dtpCreatedAt.Value = user.created_at < dtpCreatedAt.MinDate || user.created_at > dtpCreatedAt.MaxDate
                ? DateTime.Today
                : user.created_at;
        }


        private bool TryReadEditor(bool creating, out User user, out UserProfile profile, out string password)
        {
            user = null;
            profile = null;
            password = txtPassword.Text;
            var username = txtUsername.Text.Trim();
            var firstName = txtFirstName.Text.Trim();
            var middleName = txtMiddleName.Text.Trim();
            var lastName = txtLastName.Text.Trim();
            var contactNumber = txtContactNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Username, first name, and last name are required.");
                return false;
            }
            if (username.Length > 50 || firstName.Length > 50 || middleName.Length > 50 || lastName.Length > 50 || contactNumber.Length > 20)
            {
                MessageBox.Show("Username and names must not exceed 50 characters; contact number must not exceed 20 characters.");
                return false;
            }
            if ((creating && password.Length < 8) || (!creating && password.Length > 0 && password.Length < 8))
            {
                MessageBox.Show("Password must contain at least 8 characters.");
                return false;
            }
            if (cbRole.SelectedItem == null)
            {
                MessageBox.Show("Select an ADMIN role.");
                return false;
            }

            var role = cbRole.SelectedItem as UserRole;
            if (role == null)
            {
                MessageBox.Show("Select an ADMIN role.");
                return false;
            }

            var fullName = string.Join(" ", new[] { firstName, middleName, lastName }.Where(value => !string.IsNullOrWhiteSpace(value)));
            txtFullname.Text = fullName;
            user = new User
            {
                user_id = _selectedUserId.GetValueOrDefault(),
                username = username,
                full_name = fullName,
                role_id = role.role_id,
                status = cbStatus.SelectedItem == null ? "ACTIVE" : cbStatus.SelectedItem.ToString(),
                created_at = creating ? DateTime.Now : DateTime.MinValue
            };
            profile = new UserProfile
            {
                user_id = user.user_id,
                first_name = firstName,
                middle_name = string.IsNullOrWhiteSpace(middleName) ? null : middleName,
                last_name = lastName,
                contact_number = string.IsNullOrWhiteSpace(contactNumber) ? null : contactNumber
            };
            return true;
        }

        private void ClearEditorFields()
        {
            txtUsername.Clear();
            txtFullname.Clear();
            txtPassword.Clear();
            //txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtContactNumber.Clear();
            if (_adminRoles.Count > 0) cbRole.SelectedIndex = 0;
            cbStatus.SelectedItem = "ACTIVE";
            dtpCreatedAt.Value = DateTime.Today;
        }

        private void ResetToDefaultState()
        {
            _selectedUserId = null;
            ClearEditorFields();
            kryptonTextBox1.Clear();
            if (kryptonComboBox1.Items.Count > 0) kryptonComboBox1.SelectedIndex = 0;
            dgvUserManagement.ClearSelection();
            SetFormMode(UserFormMode.View);
        }

        private void SetFormMode(UserFormMode mode)
        {
            _formMode = mode;
            UpdateControlStates();
        }

        private void SetBusy(bool busy)
        {
            _isSaving = busy;
            UpdateControlStates();
        }

        private void UpdateControlStates()
        {
            var busy = _isBusy || _isSaving;
            var editing = _formMode != UserFormMode.View;
            btnAdd.Enabled = !busy && !editing;
            btnEdit.Enabled = !busy && !editing;
            btnDelete.Enabled = !busy && !editing;
            btnSave.Enabled = !busy && editing;
            btnCancel.Enabled = !busy && editing;
            dgvUserManagement.Enabled = !busy && !editing;
            kryptonTextBox1.Enabled = !busy && !editing;
            kryptonComboBox1.Enabled = !busy && !editing;

            var inputEnabled = !busy && editing;
            txtUsername.Enabled = inputEnabled;
            txtPassword.Enabled = inputEnabled;
            txtFirstName.Enabled = inputEnabled;
            txtMiddleName.Enabled = inputEnabled;
            txtLastName.Enabled = inputEnabled;
            txtContactNumber.Enabled = inputEnabled;
            cbRole.Enabled = inputEnabled;
            cbStatus.Enabled = inputEnabled;
            txtFullname.Enabled = false;
            dtpCreatedAt.Enabled = false;
        }

        private static string GetApiMessage(Exception exception)
        {
            var apiException = exception as ApiException;
            if (apiException != null && !string.IsNullOrWhiteSpace(apiException.ResponseBody))
            {
                try
                {
                    var error = JsonSerializer.Deserialize<ErrorResponse>(apiException.ResponseBody,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    if (!string.IsNullOrWhiteSpace(error?.error)) return error.error;
                }
                catch (JsonException)
                {
                    // Use the HTTP message for non-JSON error bodies.
                }
            }

            return exception.Message;
        }

    
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_formMode == UserFormMode.View || _isBusy || _isSaving) return;
            ResetToDefaultState();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (_formMode != UserFormMode.View || _isBusy || _isSaving) return;
            _selectedUserId = null;
            ClearEditorFields();
            SetFormMode(UserFormMode.Add);
            txtUsername.Focus();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (_formMode != UserFormMode.View || _isBusy || _isSaving) return;
            if (!_selectedUserId.HasValue)
            {
                MessageBox.Show("Select a user to edit.");
                return;
            }

            SetFormMode(UserFormMode.Edit);
            txtUsername.Focus();
        }

        private async void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (_formMode != UserFormMode.View || !_selectedUserId.HasValue)
            {
                MessageBox.Show("Select a user to delete.");
                return;
            }

            var user = _usersById[_selectedUserId.Value];
            var confirmed = MessageBox.Show(
                "Permanently delete user '" + user.username + "'?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmed != DialogResult.Yes) return;

            SetBusy(true);
            try
            {
                await _service.DeleteUserAsync(user.user_id, _accessToken);
                MessageBox.Show("User deleted successfully.", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await RefreshUsersAsync();
            }
            catch (Exception ex) when (ex is HttpRequestException || ex is JsonException || ex is InvalidOperationException)
            {
                MessageBox.Show(GetApiMessage(ex), "User Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetBusy(false);
            }
        }

        private async void btnSave_Click_1(object sender, EventArgs e)
        {
            if (_formMode == UserFormMode.View)
            {
                return;
            }

            User user;
            UserProfile profile;
            string password;
            var creating = _formMode == UserFormMode.Add;
            if (!TryReadEditor(creating, out user, out profile, out password)) return;
            if (!creating)
            {
                user.user_id = _selectedUserId.Value;
                user.created_at = _usersById[user.user_id].created_at;
            }
            else if (_adminRoles.Count == 0)
            {
                MessageBox.Show("The API has no ADMIN role available for user creation.");
                return;
            }

            SetBusy(true);
            try
            {
                if (creating)
                {
                    await _service.CreateUserAsync(user, profile, password, _accessToken);
                    MessageBox.Show("User created successfully.", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    await _service.UpdateUserAsync(
                        user, profile, password, _profilesById.ContainsKey(user.user_id), _accessToken);
                    MessageBox.Show("User updated successfully.", "User Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                await RefreshUsersAsync();
            }
            catch (Exception ex) when (ex is HttpRequestException || ex is JsonException || ex is InvalidOperationException)
            {
                MessageBox.Show(GetApiMessage(ex), "User Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetBusy(false);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
