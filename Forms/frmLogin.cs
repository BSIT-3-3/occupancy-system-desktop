using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            txtPass.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "1234";

            if (txtUser.Text == username && txtPass.Text == password)
            {
                MessageBox.Show("Login Successful!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                frmTryOpen openForm = new frmTryOpen();
                openForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtPass.Clear();

                txtPass.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar)
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}