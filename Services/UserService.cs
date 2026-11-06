using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using OccupancyMonitor.Models;
using System.Text.Json;
using System.Net.Http.Headers;

namespace OccupancyMonitor.Services
{
    public class UserService
    {
        private HttpClient _httpClient;
        public UserService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://127.0.0.1:5000/")
            };
        }
        public async Task<List<User>> GetUsersAsync(string accessToken)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "users");

            request.Headers.Authorization =
                new AuthenticationHeaderValue("Bearer", accessToken);

            var response = await _httpClient.SendAsync(request);

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var users = JsonSerializer.Deserialize<List<User>>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
            );

            return users ?? new List<User>();
        }
    }
}
