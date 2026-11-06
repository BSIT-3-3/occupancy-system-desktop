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
using OccupancyMonitor.Services;

namespace OccupancyMonitor.Forms
{
    public partial class ucUserProfile : UserControl
    {
        private UserService _service;
        private readonly string _accessToken;
        public ucUserProfile(UserService service, string accessToken)
        {
            InitializeComponent();
            _service = service;
            _accessToken = accessToken;
        }

        private void kryptonGroupBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void ucUserProfile_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_accessToken))
            {
                MessageBox.Show("Please log in first.");
                return;
            }
            try
            {
                var users = await _service.GetUsersAsync(_accessToken);

                dgvUserManagement.DataSource = users;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
