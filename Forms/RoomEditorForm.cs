using System;
using System.Drawing;
using System.Windows.Forms;
using OccupancyMonitor.Models;
using OccupancyMonitor.Styles;

namespace OccupancyMonitor.Forms
{
    internal sealed class RoomEditorForm : Form
    {
        private readonly TextBox _roomNumber = new TextBox();
        private readonly TextBox _roomName = new TextBox();
        private readonly CheckBox _isActive = new CheckBox();

        public RoomEditorForm(RoomModel room = null)
        {
            Text = room == null ? "Add Room" : "Edit Room";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(390, 220);
            MaximizeBox = false;
            MinimizeBox = false;

            AddLabel("Room number", 24, 26);
            _roomNumber.Location = new Point(145, 22); _roomNumber.Size = new Size(215, 24); _roomNumber.MaxLength = 50;
            AddLabel("Room name", 24, 70);
            _roomName.Location = new Point(145, 66); _roomName.Size = new Size(215, 24); _roomName.MaxLength = 50;
            _isActive.Text = "Active"; _isActive.Location = new Point(145, 108); _isActive.Checked = room == null || room.is_active;

            var save = new Button { Text = "Save", Location = new Point(180, 160), Size = new Size(85, 32) };
            AppButtonStyle.Apply(save, AppButtonType.Primary);
            save.Click += (s, e) => ValidateAndClose();
            var cancel = new Button { Text = "Cancel", Location = new Point(275, 160), Size = new Size(85, 32), DialogResult = DialogResult.Cancel };
            AppButtonStyle.Apply(cancel, AppButtonType.Secondary);
            Controls.AddRange(new Control[] { _roomNumber, _roomName, _isActive, save, cancel });
            AcceptButton = save; CancelButton = cancel;
            if (room != null) { _roomNumber.Text = room.room_number; _roomName.Text = room.room_name; }
        }

        private void AddLabel(string text, int x, int y)
        {
            Controls.Add(new Label { Text = text, Location = new Point(x, y + 3), AutoSize = true });
        }

        private void ValidateAndClose()
        {
            if (string.IsNullOrWhiteSpace(_roomNumber.Text) || string.IsNullOrWhiteSpace(_roomName.Text))
            {
                MessageBox.Show(this, "Room number and room name are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        public RoomWriteRequest GetRequest()
        {
            return new RoomWriteRequest { room_number = _roomNumber.Text.Trim(), room_name = _roomName.Text.Trim(), is_active = _isActive.Checked };
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // RoomEditorForm
            // 
            this.ClientSize = new System.Drawing.Size(944, 572);
            this.Name = "RoomEditorForm";
            this.Load += new System.EventHandler(this.RoomEditorForm_Load);
            this.ResumeLayout(false);

        }

        private void RoomEditorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
