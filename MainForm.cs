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

namespace OccupancyMonitor
{
    public partial class MainForm : Form
    {
        private prac _prac;
        private UcRoom _room;
        public MainForm()

        {
            InitializeComponent();
            _prac = new prac();
            _room = new UcRoom();
            ShowScreen(_prac);
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
            ShowScreen(_prac);
        }

        private void ktBtnRoom_Click(object sender, EventArgs e)
        {
            ShowScreen(_room);
        }
    }
}
