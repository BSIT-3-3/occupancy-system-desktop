using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using OccupancyMonitor.Forms;
using OccupancyMonitor.Services;

namespace OccupancyMonitor
{
    public partial class MainForm : Form
    {
        private Dashboard _dashboard;
        private ucRoom _room;
        private ucUserProfile _userManagement;
        public MainForm(string accesstoken, ApiClient apiClient)

        {
            InitializeComponent();
            _dashboard = new Dashboard();
            _room = new ucRoom(new RoomService(apiClient), accesstoken);
            UserService _userService = new UserService(apiClient);
            _userManagement = new ucUserProfile(_userService, accesstoken);
            ShowScreen(_dashboard);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            kbtnDashboard.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kbtnDashboard.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kbtnDashboard.OverrideFocus.Border.Draw = InheritBool.False;
        }

        private void ShowScreen(UserControl screen)
        {
            plContent.Controls.Clear();

            screen.Dock = DockStyle.Fill;

            plContent.Controls.Add(screen);
        }

        private void kbtnDashboard_Click(object sender, EventArgs e)
        {
            ShowScreen(_dashboard);
        }

        private void kplNavBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kBtnActiveEmergency_Click(object sender, EventArgs e)
        {

        }

        private void kbtnUserManagement_Click(object sender, EventArgs e)
        {
            ShowScreen(_userManagement);
        }

        private void btnRoomManagement_Click(object sender, EventArgs e)
        {
            ShowScreen(_room);
        }
    }
}
