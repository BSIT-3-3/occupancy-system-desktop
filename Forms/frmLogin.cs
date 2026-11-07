using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OccupancyMonitor;
using OccupancyMonitor.Services;
using OccupancyMonitor.Models;
using System.Net.Http;
namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
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
