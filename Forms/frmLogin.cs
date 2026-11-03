using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using OccupancyMonitor.Services;
using OccupancyMonitor.Models;
namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        private HttpClient _client;

        public frmLogin()
        {
            InitializeComponent();

            txtPass.UseSystemPasswordChar = true;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var login = new LoginService();

            var request = new LoginRequest()
            {
                username = txtUser.Text,
                password = txtPass.Text
            };

           await login.Login(request);

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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}