using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OccupancyMonitor.Models;
using OccupancyMonitor.Services;
using OccupancyMonitor.Styles;

namespace OccupancyMonitor.Forms
{
    public partial class uccDeviceManagement : UserControl
    {
        private readonly DeviceService _deviceService;
        private readonly RoomService _roomService;
        private readonly string _accessToken;
        private readonly List<DeviceModel> _devices = new List<DeviceModel>();
        private readonly List<RoomModel> _rooms = new List<RoomModel>();
        private readonly List<RoomModel> _availableRooms = new List<RoomModel>();
        private DeviceFormMode _mode = DeviceFormMode.View;
        private bool _isBusy;

        private enum DeviceFormMode { View, Add, Edit }

        public uccDeviceManagement(DeviceService deviceService, RoomService roomService, string accessToken)
        {
            InitializeComponent();
            AppDataGridViewStyle.Apply(dgvDevices);
            AppButtonStyle.Apply(btnAdd, AppButtonType.Primary);
            AppButtonStyle.Apply(btnEdit, AppButtonType.Primary);
            AppButtonStyle.Apply(btnDelete, AppButtonType.Danger);
            AppButtonStyle.Apply(btnSave, AppButtonType.Primary);
            AppButtonStyle.Apply(btnCancel, AppButtonType.Secondary);
            _deviceService = deviceService ?? throw new ArgumentNullException(nameof(deviceService));
            _roomService = roomService ?? throw new ArgumentNullException(nameof(roomService));
            _accessToken = accessToken;

            txtDeviceId.MaxLength = 20;
            txtDeviceCode.MaxLength = 50;
            txtDeviceName.MaxLength = 50;
            dgvDevices.AutoGenerateColumns = true;
            dgvDevices.ReadOnly = true;
            dtpCreatedAt.ShowCheckBox = true;
            cbStatusFilter.Items.AddRange(new object[] { "All Statuses", "PENDING", "REGISTERED", "DEACTIVATED" });
            cbStatusFilter.SelectedIndex = 0;

            dgvDevices.SelectionChanged += dgvDevices_SelectionChanged;
            txtSearch.TextChanged += filterControls_Changed;
            cbStatusFilter.SelectedIndexChanged += filterControls_Changed;
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            UpdateControlStates();
        }

        private async void uccDeviceManagement_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        public async Task RefreshDataAsync()
        {
            await LoadDataAsync();
        }

        private async Task<bool> LoadDataAsync(string selectDeviceId = null)
        {
            if (_isBusy) return false;
            if (string.IsNullOrWhiteSpace(_accessToken))
            {
                MessageBox.Show(this, "Please log in again to manage devices.", "Device Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            _isBusy = true;
            UpdateControlStates();
            try
            {
                var rooms = await _roomService.GetRoomsAsync(_accessToken);
                var devices = await _deviceService.GetDevicesAsync(_accessToken);
                var availableRooms = await _deviceService.GetAvailableRoomsAsync(_accessToken);
                _rooms.Clear();
                _rooms.AddRange(rooms ?? new List<RoomModel>());
                _devices.Clear();
                _devices.AddRange(devices ?? new List<DeviceModel>());
                _availableRooms.Clear();
                _availableRooms.AddRange(availableRooms ?? new List<RoomModel>());
                BindRoomChoices();
                _mode = DeviceFormMode.View;
                ApplyFilters(selectDeviceId);
                return true;
            }
            catch (Exception ex)
            {
                ShowError(ex);
                return false;
            }
            finally
            {
                _isBusy = false;
                UpdateControlStates();
            }
        }

        private void BindRoomChoices(bool onlyEligible = false, string currentDeviceId = null)
        {
            IEnumerable<RoomModel> rooms = onlyEligible ? _availableRooms : _rooms;
            if (onlyEligible)
            {
                var currentDevice = string.IsNullOrWhiteSpace(currentDeviceId)
                    ? null
                    : _devices.FirstOrDefault(device =>
                        string.Equals(device.device_id, currentDeviceId, StringComparison.Ordinal));
                if (currentDevice?.room != null && currentDevice.room.is_active)
                {
                    var currentRoom = _rooms.FirstOrDefault(room => room.room_id == currentDevice.room_id);
                    if (currentRoom != null && !rooms.Any(room => room.room_id == currentRoom.room_id))
                    {
                        rooms = rooms.Concat(new[] { currentRoom });
                    }
                }
            }

            var choices = rooms
                .OrderBy(room => room.room_number, StringComparer.OrdinalIgnoreCase)
                .ThenBy(room => room.room_id)
                .Select(room => new RoomChoice
                {
                    RoomId = room.room_id,
                    DisplayName = room.room_number + " - " + room.room_name
                }).ToList();
            cbRoom.DataSource = null;
            cbRoom.DisplayMember = nameof(RoomChoice.DisplayName);
            cbRoom.ValueMember = nameof(RoomChoice.RoomId);
            cbRoom.DataSource = choices;
            cbRoom.SelectedIndex = -1;
        }

        private void ApplyFilters(string selectDeviceId = null)
        {
            var search = txtSearch.Text.Trim();
            var statusFilter = cbStatusFilter.SelectedItem as string;
            var rows = _devices.Where(device =>
                    string.Equals(device.device_id, selectDeviceId, StringComparison.Ordinal) ||
                    ((string.IsNullOrWhiteSpace(search) ||
                        Contains(device.device_id, search) ||
                        Contains(device.device_code, search) ||
                        Contains(device.device_name, search) ||
                        Contains(device.room?.room_number, search) ||
                        Contains(device.room?.room_name, search)) &&
                    (string.IsNullOrWhiteSpace(statusFilter) || statusFilter == "All Statuses" ||
                        string.Equals(device.registration_status, statusFilter, StringComparison.OrdinalIgnoreCase))))
                .Select(ToGridRow)
                .ToList();

            dgvDevices.SelectionChanged -= dgvDevices_SelectionChanged;
            dgvDevices.DataSource = null;
            dgvDevices.DataSource = rows;
            ConfigureGridColumns();
            dgvDevices.ClearSelection();
            dgvDevices.SelectionChanged += dgvDevices_SelectionChanged;
            ClearFields();
            if (!string.IsNullOrWhiteSpace(selectDeviceId))
            {
                foreach (DataGridViewRow row in dgvDevices.Rows)
                {
                    var item = row.DataBoundItem as DeviceManagementRow;
                    if (item == null || !string.Equals(item.DeviceId, selectDeviceId, StringComparison.Ordinal)) continue;
                    row.Selected = true;
                    if (row.Cells.Count > 0) dgvDevices.CurrentCell = row.Cells[0];
                    break;
                }
            }
            UpdateControlStates();
        }

        private static DeviceManagementRow ToGridRow(DeviceModel device)
        {
            return new DeviceManagementRow
            {
                DeviceId = device.device_id,
                DeviceCode = device.device_code,
                DeviceName = device.device_name ?? string.Empty,
                Room = device.room == null
                    ? device.room_id.ToString(CultureInfo.InvariantCulture) + " (Room unavailable)"
                    : device.room.room_number + " - " + device.room.room_name +
                        (device.room.is_active ? string.Empty : " (Inactive)"),
                RegistrationStatus = device.registration_status,
                RegisteredAt = device.registered_at.HasValue
                    ? device.registered_at.Value.ToLocalTime().ToString("g", CultureInfo.CurrentCulture)
                    : "—"
            };
        }

        private void ConfigureGridColumns()
        {
            if (dgvDevices.Columns.Count == 0) return;
            dgvDevices.Columns[nameof(DeviceManagementRow.DeviceId)].HeaderText = "Device ID";
            dgvDevices.Columns[nameof(DeviceManagementRow.DeviceCode)].HeaderText = "Device Code";
            dgvDevices.Columns[nameof(DeviceManagementRow.DeviceName)].HeaderText = "Device Name";
            dgvDevices.Columns[nameof(DeviceManagementRow.Room)].HeaderText = "Room";
            dgvDevices.Columns[nameof(DeviceManagementRow.RegistrationStatus)].HeaderText = "Status";
            dgvDevices.Columns[nameof(DeviceManagementRow.RegisteredAt)].HeaderText = "Registered At";
        }

        private static bool Contains(string value, string term)
        {
            return !string.IsNullOrEmpty(value) && value.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private DeviceModel SelectedDevice
        {
            get
            {
                var row = dgvDevices.SelectedRows.Count == 0
                    ? null
                    : dgvDevices.SelectedRows[0].DataBoundItem as DeviceManagementRow;
                return row == null ? null : _devices.FirstOrDefault(device => device.device_id == row.DeviceId);
            }
        }

        private void dgvDevices_SelectionChanged(object sender, EventArgs e)
        {
            if (_mode != DeviceFormMode.View) return;
            var selected = SelectedDevice;
            if (selected == null) ClearFields();
            else ShowDevice(selected);
            UpdateControlStates();
        }

        private void ShowDevice(DeviceModel device)
        {
            txtDeviceId.Text = device.device_id;
            txtDeviceCode.Text = device.device_code;
            txtDeviceName.Text = device.device_name ?? string.Empty;
            SetDisplayStatus(device.registration_status);
            if (device.registered_at.HasValue)
            {
                dtpCreatedAt.Value = device.registered_at.Value.LocalDateTime;
                dtpCreatedAt.Checked = true;
            }
            else
            {
                dtpCreatedAt.Checked = false;
            }
            cbRoom.SelectedValue = device.room_id;
        }

        private void SetDisplayStatus(string status)
        {
            cbStatus.Items.Clear();
            cbStatus.Items.AddRange(new object[] { "PENDING", "REGISTERED", "DEACTIVATED" });
            cbStatus.SelectedItem = status;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (_isBusy || !await LoadDataAsync()) return;
            BindRoomChoices(onlyEligible: true);
            dgvDevices.ClearSelection();
            ClearFields();
            cbStatus.Items.Clear();
            cbStatus.Items.Add("PENDING");
            cbStatus.SelectedIndex = 0;
            _mode = DeviceFormMode.Add;
            UpdateControlStates();
            txtDeviceId.Focus();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            var selected = SelectedDevice;
            if (_isBusy || selected == null) return;
            var deviceId = selected.device_id;
            if (!await LoadDataAsync(deviceId)) return;
            selected = _devices.FirstOrDefault(device => string.Equals(device.device_id, deviceId, StringComparison.Ordinal));
            if (selected == null)
            {
                MessageBox.Show(this, "The selected device is no longer available. Refresh the list and try again.",
                    "Device Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            BindRoomChoices(onlyEligible: true, currentDeviceId: deviceId);
            ShowDevice(selected);
            cbStatus.Items.Clear();
            cbStatus.Items.AddRange(new object[] { "Keep current", "PENDING", "DEACTIVATED" });
            cbStatus.SelectedIndex = 0;
            _mode = DeviceFormMode.Edit;
            UpdateControlStates();
            txtDeviceCode.Focus();
        }


        private bool ValidateForm()
        {
            if (_mode == DeviceFormMode.Add && string.IsNullOrWhiteSpace(txtDeviceId.Text))
            {
                ShowValidationError("Device ID is required.");
                txtDeviceId.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDeviceCode.Text))
            {
                ShowValidationError("Device code is required.");
                txtDeviceCode.Focus();
                return false;
            }
            if (cbRoom.SelectedValue == null || !(cbRoom.SelectedValue is int))
            {
                ShowValidationError("Select an active room for this device.");
                cbRoom.Focus();
                return false;
            }
            return true;
        }

        private void ShowValidationError(string message)
        {
            MessageBox.Show(this, message, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private async Task ReloadAfterChangeAsync()
        {
            _mode = DeviceFormMode.View;
            _isBusy = false;
            await LoadDataAsync();
        }

        private void ClearFields()
        {
            txtDeviceId.Clear();
            txtDeviceCode.Clear();
            txtDeviceName.Clear();
            cbStatus.Items.Clear();
            dtpCreatedAt.Checked = false;
            cbRoom.SelectedIndex = -1;
        }

        private void filterControls_Changed(object sender, EventArgs e)
        {
            if (_mode == DeviceFormMode.View) ApplyFilters();
        }

        private void UpdateControlStates()
        {
            var editing = _mode != DeviceFormMode.View;
            var selected = SelectedDevice != null;
            var busy = _isBusy;
            dgvDevices.Enabled = !busy && !editing;
            txtSearch.Enabled = !busy && !editing;
            cbStatusFilter.Enabled = !busy && !editing;
            btnAdd.Enabled = !busy && !editing;
            btnEdit.Enabled = !busy && !editing && selected;
            btnDelete.Enabled = !busy && !editing && selected &&
                !string.Equals(SelectedDevice?.registration_status, "DEACTIVATED", StringComparison.OrdinalIgnoreCase);
            btnSave.Enabled = !busy && editing;
            btnCancel.Enabled = !busy && editing;
            txtDeviceId.Enabled = !busy && _mode == DeviceFormMode.Add;
            txtDeviceCode.Enabled = !busy && editing;
            txtDeviceName.Enabled = !busy && editing;
            cbRoom.Enabled = !busy && editing;
            cbStatus.Enabled = !busy && _mode == DeviceFormMode.Edit;
            dtpCreatedAt.Enabled = false;
        }

        private void ShowError(Exception exception)
        {
            var apiException = exception as ApiException;
            var message = apiException != null ? apiException.GetDisplayMessage() : exception.Message;
            MessageBox.Show(this, message, "Device Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private sealed class RoomChoice
        {
            public int RoomId { get; set; }
            public string DisplayName { get; set; }
        }

        private async void btnDelete_Click_1(object sender, EventArgs e)
        {
            var selected = SelectedDevice;
            if (_isBusy || selected == null) return;
            if (MessageBox.Show(this, "Deactivate device " + selected.device_id + "? Its history will be preserved.",
                    "Confirm deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            _isBusy = true;
            UpdateControlStates();
            try
            {
                await _deviceService.DeactivateDeviceAsync(selected.device_id, _accessToken);
                MessageBox.Show(this, "Device deactivated successfully.", "Device Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                await ReloadAfterChangeAsync();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            finally
            {
                _isBusy = false;
                UpdateControlStates();
            }
        }

        private async void btnSave_Click_1(object sender, EventArgs e)
        {
            if (_isBusy || !ValidateForm()) return;
            var roomId = (int)cbRoom.SelectedValue;
            _isBusy = true;
            UpdateControlStates();
            try
            {
                if (_mode == DeviceFormMode.Add)
                {
                    var request = new DeviceCreateRequest
                    {
                        device_id = txtDeviceId.Text.Trim(),
                        device_code = txtDeviceCode.Text.Trim(),
                        device_name = txtDeviceName.Text.Trim(),
                        room_id = roomId
                    };
                    await _deviceService.CreateDeviceAsync(request, _accessToken);
                    MessageBox.Show(this, "Device registered and is pending provisioning.", "Device Management",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (_mode == DeviceFormMode.Edit)
                {
                    var selected = SelectedDevice;
                    if (selected == null) return;
                    var status = cbStatus.SelectedItem as string;
                    if (status == "PENDING" || status == "DEACTIVATED")
                    {
                        var requestWithStatus = new DeviceUpdateWithStatusRequest
                        {
                            device_code = txtDeviceCode.Text.Trim(),
                            device_name = txtDeviceName.Text.Trim(),
                            room_id = roomId,
                            registration_status = status
                        };
                        await _deviceService.UpdateDeviceWithStatusAsync(selected.device_id, requestWithStatus, _accessToken);
                    }
                    else
                    {
                        var request = new DeviceUpdateRequest
                        {
                            device_code = txtDeviceCode.Text.Trim(),
                            device_name = txtDeviceName.Text.Trim(),
                            room_id = roomId
                        };
                        await _deviceService.UpdateDeviceAsync(selected.device_id, request, _accessToken);
                    }
                    MessageBox.Show(this, "Device updated successfully.", "Device Management",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                _mode = DeviceFormMode.View;
                await ReloadAfterChangeAsync();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            finally
            {
                _isBusy = false;
                UpdateControlStates();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            _mode = DeviceFormMode.View;
            ClearFields();
            dgvDevices.ClearSelection();
            UpdateControlStates();
        }
    }
}
