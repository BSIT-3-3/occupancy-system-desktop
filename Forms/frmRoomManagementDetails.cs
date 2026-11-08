using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using OccupancyMonitor.Models;
using OccupancyMonitor.Services;
using OccupancyMonitor.Styles;

namespace OccupancyMonitor.Forms
{
    public partial class RoomManagement : Form
    {
        private RoomModel _room;
        private readonly RoomService _service;
        private readonly string _accessToken;

        public RoomManagement(RoomModel room, RoomService service, string accessToken)
        {
            InitializeComponent();
            _room = room;
            _service = service;
            _accessToken = accessToken;

            AppButtonStyle.Apply(btnEditRoom, AppButtonType.Primary);
            BindRoom();
        }

        private void BindRoom()
        {
            label3.Text = _room.room_number + " - " + _room.room_name;
            label5.Text = label3.Text;
            label4.Text = "Unavailable";
            label13.Text = _room.is_active ? "Active" : "Inactive";
            label14.Text = _room.occupancy_status ?? "Unknown";
            label15.Text = _room.last_occupancy_update.HasValue
                ? _room.last_occupancy_update.Value.ToLocalTime().ToString("g", CultureInfo.CurrentCulture)
                : "Unavailable";
            label18.Text = "Unavailable";
            label26.Text = "Unavailable";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditRoomAsync();
        }

        private async void EditRoomAsync()
        {
            using (var editor = new RoomEditorForm(_room))
            {
                if (editor.ShowDialog(this) != DialogResult.OK) return;
                try
                {
                    _room = await _service.UpdateRoomAsync(_room.room_id, editor.GetRequest(), _accessToken);
                    BindRoom();
                }
                catch (Exception ex)
                {
                    var apiError = ex as ApiException;
                    MessageBox.Show(this, apiError != null ? apiError.GetDisplayMessage() : ex.Message,
                        "Room Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
