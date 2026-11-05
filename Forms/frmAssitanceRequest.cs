using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OccupancyMonitor.Forms
{
    public partial class frmAssitanceRequest : Form
    {
        public frmAssitanceRequest()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void frmAssitanceRequest_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
                "Room 3-4",
                "DEV-004",
                "OCT. 26, 2026 12:21",
                "Pending",
                "Acknowledge"
                );
        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
