using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OccupancyMonitor.Styles;

namespace OccupancyMonitor.Forms
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            AppButtonStyle.Apply(button2, AppButtonType.Primary);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
