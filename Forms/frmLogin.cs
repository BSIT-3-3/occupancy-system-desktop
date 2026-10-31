using System;
using System.Collections.Generic;
using System.ComponentModel;
<<<<<<< HEAD
using System.Data;
using System.Drawing;
=======
using System.Drawing;
using System.Data;
>>>>>>> 7f8b870 (frmLogin, frmExit)
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using OccupancyMonitor;
using OccupancyMonitor.Services;
using OccupancyMonitor.Models;
using System.Net.Http;
=======

>>>>>>> 7f8b870 (frmLogin, frmExit)
namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
<<<<<<< HEAD
        private readonly LoginService _loginService;
        private readonly ApiClient _apiClient;

        public frmLogin(ApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
            _loginService = new LoginService(apiClient);

            txtPass.UseSystemPasswordChar = true;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var request = new LoginRequest()
            {
                username = txtUser.Text,
                password = txtPass.Text
            };

            try
            {
                var result = await _loginService.LoginAsync(request);
                var mainForm = new MainForm(result.access_token, _apiClient);
                mainForm.Show();
            }
            catch (ApiException ex)
            {
                MessageBox.Show(ex.GetDisplayMessage());
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }

=======
        public frmLogin()
        {
            InitializeComponent();

            // Hide password while typing
            txtPass.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "1234";

            // Check username and password
            if (txtUser.Text == username && txtPass.Text == password)
            {
                MessageBox.Show(
                    "Login Successful!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Open MainForm
                frmLogin openForm = new frmLogin();
                openForm.Show();

                // Hide Login Form
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Incorrect username or password!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                // Clear password
                txtPass.Clear();

                // Put cursor back in password textbox
                txtPass.Focus();
            }
>>>>>>> 7f8b870 (frmLogin, frmExit)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
>>>>>>> 7f8b870 (frmLogin, frmExit)
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
>>>>>>> 7f8b870 (frmLogin, frmExit)
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (txtPass.UseSystemPasswordChar)
            {
=======
            // Show/hide password
            if (txtPass.UseSystemPasswordChar)
            {
                // Show password
>>>>>>> 7f8b870 (frmLogin, frmExit)
                txtPass.UseSystemPasswordChar = false;
                txtPass.PasswordChar = '\0';
            }
            else
            {
<<<<<<< HEAD
=======
                // Hide password
>>>>>>> 7f8b870 (frmLogin, frmExit)
                txtPass.UseSystemPasswordChar = true;
            }
        }

<<<<<<< HEAD
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
=======
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
        }
    }
}
>>>>>>> 7f8b870 (frmLogin, frmExit)
