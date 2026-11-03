using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using OccupancyMonitor.Models;
using System.Text.Json;
using System.Windows.Forms;

namespace OccupancyMonitor.Services
{
    public class LoginService
    {
        private readonly HttpClient _httpClient;

        public LoginService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://127.0.0.1:5000/")
            };
        }

        public async Task<LoginResponse> Login(LoginRequest requests)
        {
            var request = new LoginRequest()
            {
                username = requests.username,
                password = requests.password
            };

            var json = JsonSerializer.Serialize(request);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("/api/auth/login", content);

            var data = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var result = JsonSerializer.Deserialize<LoginResponse>(
                    data,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                );

                MessageBox.Show(result.User.Full_Name);

                var frm = new MainForm();
                frm.Show();
                return result;
            }
            else
            {
                var error = JsonSerializer.Deserialize<ErrorResponse>(
                    data,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                );

                MessageBox.Show(error?.error ?? "Unknown error");

                return null;
            }
        }
    }
}
