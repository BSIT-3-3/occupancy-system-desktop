using System;
using System.Windows.Forms;

namespace OccupancyMonitor.Forms
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();

            txtpassword2.Multiline = false;
            txtpassword2.UseSystemPasswordChar = true;

            txtconfirmpassword2.Multiline = false;
            txtconfirmpassword2.UseSystemPasswordChar = true;

            chkShowPassword.Checked = false;
            chkShowPassword1.Checked = false;

            chkShowPassword1.CheckedChanged += chkShowPassword1_CheckedChanged;
        }

        private void label3_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void label5_Click(object sender, EventArgs e) { }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            txtpassword2.UseSystemPasswordChar = true;
            txtconfirmpassword2.UseSystemPasswordChar = true;
        }

        private void label6_Click(object sender, EventArgs e) { }

        private void label13_Click(object sender, EventArgs e) { }

        private void label17_Click(object sender, EventArgs e) { }

        private void label16_Click(object sender, EventArgs e) { }

        private void label15_Click(object sender, EventArgs e) { }

        private void label18_Click(object sender, EventArgs e) { }

        private void label14_Click(object sender, EventArgs e) { }

        private void frmRegister_Load_1(object sender, EventArgs e) { }

        private void txtpassword2_TextChanged(object sender, EventArgs e) { }

        private void txtconfirmpassword2_TextChanged(object sender, EventArgs e) { }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword2.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void chkShowPassword1_CheckedChanged(object sender, EventArgs e)
        {
            txtconfirmpassword2.UseSystemPasswordChar = !chkShowPassword1.Checked;
        }
    }
}