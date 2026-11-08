using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using OccupancyMonitor.Models;
using OccupancyMonitor.Services;
using OccupancyMonitor.Styles;

namespace OccupancyMonitor.Forms
{
    public partial class ucRoom : UserControl
    {
        private KryptonDataGridView kdgvRooms;

        private readonly RoomService _service;
        private readonly string _accessToken;
        private readonly Button _addButton;
        private readonly Button _editButton;
        private readonly Button _deactivateButton;
        private readonly Button _refreshButton;
        private KryptonComboBox cbStatusFilter;
        private Label label1;
        private KryptonTextBox txtSearch;
        private KryptonDateTimePicker dtpCreatedAt;
        private KryptonComboBox cbStatus;
        private Label label7;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnCancel;
        private Button btnSave;
        private KryptonTextBox txtRoomName;
        private KryptonTextBox txtRoomID;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Label label9;
        private Label label10;
        private List<RoomModel> _rooms = new List<RoomModel>();

        public ucRoom(RoomService service, string accessToken)
        {
            InitializeComponent();
            AppDataGridViewStyle.Apply(kdgvRooms);
            AppButtonStyle.Apply(btnAdd, AppButtonType.Primary);
            AppButtonStyle.Apply(btnEdit, AppButtonType.Primary);
            AppButtonStyle.Apply(btnDelete, AppButtonType.Danger);
            AppButtonStyle.Apply(btnSave, AppButtonType.Primary);
            AppButtonStyle.Apply(btnCancel, AppButtonType.Secondary);
            _editButton = btnEdit;
            _deactivateButton = btnDelete;
            _service = service ?? throw new ArgumentNullException(nameof(service));
            _accessToken = accessToken;
            kdgvRooms.AutoGenerateColumns = true;
            _editButton.Enabled = false;
            _deactivateButton.Enabled = false;
            kdgvRooms.SelectionChanged += RoomsGrid_SelectionChanged;

            cbStatusFilter.Items.AddRange(new object[] { "All Statuses", "Active", "Inactive" });
            cbStatusFilter.SelectedIndex = 0;
            cbStatusFilter.SelectedIndexChanged += RoomFilter_Changed;
            txtSearch.TextChanged += RoomFilter_Changed;
        }
        #region -- initialize
        private void InitializeComponent()
        {
            this.kdgvRooms = new Krypton.Toolkit.KryptonDataGridView();
            this.cbStatusFilter = new Krypton.Toolkit.KryptonComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Krypton.Toolkit.KryptonTextBox();
            this.dtpCreatedAt = new Krypton.Toolkit.KryptonDateTimePicker();
            this.cbStatus = new Krypton.Toolkit.KryptonComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRoomName = new Krypton.Toolkit.KryptonTextBox();
            this.txtRoomID = new Krypton.Toolkit.KryptonTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kdgvRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatusFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kdgvRooms
            // 
            this.kdgvRooms.AllowUserToAddRows = false;
            this.kdgvRooms.AllowUserToDeleteRows = false;
            this.kdgvRooms.AllowUserToResizeColumns = false;
            this.kdgvRooms.AllowUserToResizeRows = false;
            this.kdgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kdgvRooms.Location = new System.Drawing.Point(14, 92);
            this.kdgvRooms.MultiSelect = false;
            this.kdgvRooms.Name = "kdgvRooms";
            this.kdgvRooms.RowHeadersVisible = false;
            this.kdgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kdgvRooms.Size = new System.Drawing.Size(694, 500);
            this.kdgvRooms.TabIndex = 0;
            // 
            // cbStatusFilter
            // 
            this.cbStatusFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusFilter.DropDownWidth = 137;
            this.cbStatusFilter.IntegralHeight = false;
            this.cbStatusFilter.Location = new System.Drawing.Point(420, 33);
            this.cbStatusFilter.Name = "cbStatusFilter";
            this.cbStatusFilter.Size = new System.Drawing.Size(141, 25);
            this.cbStatusFilter.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbStatusFilter.StateCommon.ComboBox.Border.Rounding = 5F;
            this.cbStatusFilter.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbStatusFilter.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(52, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(281, 27);
            this.txtSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Border.Rounding = 5F;
            this.txtSearch.TabIndex = 5;
            // 
            // dtpCreatedAt
            // 
            this.dtpCreatedAt.CustomFormat = "yyyy-MM-dd";
            this.dtpCreatedAt.Enabled = false;
            this.dtpCreatedAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreatedAt.Location = new System.Drawing.Point(114, 236);
            this.dtpCreatedAt.Name = "dtpCreatedAt";
            this.dtpCreatedAt.Size = new System.Drawing.Size(165, 23);
            this.dtpCreatedAt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpCreatedAt.StateCommon.Border.Rounding = 2F;
            this.dtpCreatedAt.TabIndex = 15;
            // 
            // cbStatus
            // 
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.DropDownWidth = 137;
            this.cbStatus.IntegralHeight = false;
            this.cbStatus.Location = new System.Drawing.Point(114, 189);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(165, 23);
            this.cbStatus.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbStatus.StateCommon.ComboBox.Border.Rounding = 2F;
            this.cbStatus.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbStatus.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Created At:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Status:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.dtpCreatedAt);
            this.groupBox1.Controls.Add(this.txtRoomName);
            this.groupBox1.Controls.Add(this.txtRoomID);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(715, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 602);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Details";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(162, 466);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 36);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(18, 466);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 36);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(114, 139);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(165, 23);
            this.txtRoomName.TabIndex = 4;
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(114, 103);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(165, 23);
            this.txtRoomID.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(18, 424);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(276, 36);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(18, 376);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(276, 36);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 328);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(276, 36);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "RoomID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Room Name:";
            // 
            // ucRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbStatusFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kdgvRooms);
            this.Name = "ucRoom";
            this.Size = new System.Drawing.Size(1054, 618);
            this.Load += new System.EventHandler(this.ucRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kdgvRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatusFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatus)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private async Task LoadRoomsAsync()
        {
            try
            {
                _rooms = await _service.GetRoomsAsync(_accessToken) ?? new List<RoomModel>();
                ApplyRoomFilters();
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void ApplyRoomFilters()
        {
            var search = txtSearch.Text.Trim();
            var statusFilter = cbStatusFilter.SelectedItem as string;
            var filteredRooms = _rooms.Where(item =>
                (string.IsNullOrWhiteSpace(search) ||
                    Contains(item.room_number, search) ||
                    Contains(item.room_name, search) ||
                    Contains(item.occupancy_status, search)) &&
                (statusFilter == "All Statuses" || string.IsNullOrEmpty(statusFilter) ||
                    (statusFilter == "Active" && item.is_active) ||
                    (statusFilter == "Inactive" && !item.is_active)))
                .ToList();

            var rows = filteredRooms.Select(item => new RoomManagementRow
            {
                RoomId = item.room_id,
                Room = item.room_number + " - " + item.room_name,
                Device = "Unavailable",
                LastActivity = item.last_occupancy_update.HasValue
                    ? item.last_occupancy_update.Value.ToLocalTime().ToString("g", CultureInfo.CurrentCulture)
                    : "—",
                Occupancy = item.occupancy_status,
                Status = item.is_active ? "Active" : "Inactive"
            }).ToList();

            kdgvRooms.SelectionChanged -= RoomsGrid_SelectionChanged;
            kdgvRooms.DataSource = null;
            kdgvRooms.DataSource = rows;
            ConfigureGridColumns();
            kdgvRooms.ClearSelection();
            kdgvRooms.SelectionChanged += RoomsGrid_SelectionChanged;
            UpdateSelectionActions();
        }

        private static bool Contains(string value, string term)
        {
            return !string.IsNullOrEmpty(value) &&
                value.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private void RoomFilter_Changed(object sender, EventArgs e)
        {
            ApplyRoomFilters();
        }

        private void ConfigureGridColumns()
        {
            if (kdgvRooms.Columns.Count == 0) return;
            kdgvRooms.Columns[nameof(RoomManagementRow.RoomId)].HeaderText = "ID";
            kdgvRooms.Columns[nameof(RoomManagementRow.RoomId)].Visible = false;
            kdgvRooms.Columns[nameof(RoomManagementRow.Room)].HeaderText = "Room";
            kdgvRooms.Columns[nameof(RoomManagementRow.Device)].HeaderText = "Device";
            kdgvRooms.Columns[nameof(RoomManagementRow.LastActivity)].HeaderText = "Last Activity";
            kdgvRooms.Columns[nameof(RoomManagementRow.Occupancy)].HeaderText = "Occupancy";
            kdgvRooms.Columns[nameof(RoomManagementRow.Status)].HeaderText = "Status";
        }

        private RoomModel SelectedRoom
        {
            get
            {
                var row = kdgvRooms.SelectedRows.Count == 0
                    ? null
                    : kdgvRooms.SelectedRows[0].DataBoundItem as RoomManagementRow;
                return row == null ? null : _rooms.FirstOrDefault(item => item.room_id == row.RoomId);
            }
        }

        private void RoomsGrid_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelectionActions();
        }

        private void UpdateSelectionActions()
        {
            var selected = SelectedRoom != null;
            _editButton.Enabled = selected;
            _deactivateButton.Enabled = selected && SelectedRoom.is_active;
        }

        private async Task AddRoomAsync()
        {
            using (var editor = new RoomEditorForm())
            {
                if (editor.ShowDialog(this) != DialogResult.OK) return;
                try { await _service.CreateRoomAsync(editor.GetRequest(), _accessToken); await LoadRoomsAsync(); }
                catch (Exception ex) { ShowError(ex); }
            }
        }

        private async Task EditSelectedRoomAsync()
        {
            var selected = SelectedRoom;
            if (selected == null) return;
            using (var editor = new RoomEditorForm(selected))
            {
                if (editor.ShowDialog(this) != DialogResult.OK) return;
                try { await _service.UpdateRoomAsync(selected.room_id, editor.GetRequest(), _accessToken); await LoadRoomsAsync(); }
                catch (Exception ex) { ShowError(ex); }
            }
        }

        private async Task DeactivateSelectedRoomAsync()
        {
            var selected = SelectedRoom;
            if (selected == null || MessageBox.Show(this, "Deactivate room " + selected.room_number + "?", "Confirm deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try { await _service.DeactivateRoomAsync(selected.room_id, _accessToken); await LoadRoomsAsync(); }
            catch (Exception ex) { ShowError(ex); }
        }

        private async Task OpenDetailsAsync()
        {
            var selected = SelectedRoom;
            if (selected == null) return;
            using (var details = new RoomManagement(selected, _service, _accessToken)) details.ShowDialog(this);
            await LoadRoomsAsync();
        }

        private void ShowError(Exception ex)
        {
            var apiError = ex as ApiException;
            MessageBox.Show(this, apiError != null ? apiError.GetDisplayMessage() : ex.Message, "Room Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void ucRoom_Load(object sender, EventArgs e)
        {
            await LoadRoomsAsync();
        }


        private async void btnAdd_Click(object sender, EventArgs e)
        {
            await AddRoomAsync();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            await EditSelectedRoomAsync();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            await DeactivateSelectedRoomAsync();
        }
    }
}
