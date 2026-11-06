using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;

namespace OccupancyMonitor.Forms
{
    public partial class ucRoom : UserControl
    {
        private DataGridViewTextBoxColumn room_id;
        private DataGridViewTextBoxColumn room;
        private DataGridViewTextBoxColumn device;
        private DataGridViewTextBoxColumn lastActivity;
        private DataGridViewTextBoxColumn occupancy;
        private DataGridViewTextBoxColumn status;
        private Krypton.Toolkit.KryptonDataGridView kdgvRooms;


 

        private void InitializeComponent()
        {
            this.kdgvRooms = new Krypton.Toolkit.KryptonDataGridView();
            this.room_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastActivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupancy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kdgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // kdgvRooms
            // 
            this.kdgvRooms.AllowUserToAddRows = false;
            this.kdgvRooms.AllowUserToDeleteRows = false;
            this.kdgvRooms.AllowUserToResizeColumns = false;
            this.kdgvRooms.AllowUserToResizeRows = false;
            this.kdgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kdgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.room_id,
            this.room,
            this.device,
            this.lastActivity,
            this.occupancy,
            this.status});
            this.kdgvRooms.Location = new System.Drawing.Point(0, 109);
            this.kdgvRooms.Name = "kdgvRooms";
            this.kdgvRooms.RowHeadersVisible = false;
            this.kdgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kdgvRooms.Size = new System.Drawing.Size(1208, 319);
            this.kdgvRooms.TabIndex = 0;
            // 
            // room_id
            // 
            this.room_id.HeaderText = "ID";
            this.room_id.Name = "room_id";
            this.room_id.Visible = false;
            // 
            // room
            // 
            this.room.HeaderText = "Room";
            this.room.Name = "room";
            // 
            // device
            // 
            this.device.HeaderText = "Device";
            this.device.Name = "device";
            // 
            // lastActivity
            // 
            this.lastActivity.HeaderText = "Last Activity";
            this.lastActivity.Name = "lastActivity";
            // 
            // occupancy
            // 
            this.occupancy.HeaderText = "Occupancy";
            this.occupancy.Name = "occupancy";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // ucRoom
            // 
            this.Controls.Add(this.kdgvRooms);
            this.Name = "ucRoom";
            this.Size = new System.Drawing.Size(1208, 618);
            this.Load += new System.EventHandler(this.ucRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kdgvRooms)).EndInit();
            this.ResumeLayout(false);

        }

        private HttpClient _client;

        public ucRoom()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("http://127.0.0.1:5000/")
            };
        }

        private async void ucRoom_Load(object sender, EventArgs e)
        {
            var response = await _client.GetAsync("");
        }
    }
}
