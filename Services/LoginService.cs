using System;
using System.Threading.Tasks;
using OccupancyMonitor.Models;

namespace OccupancyMonitor.Services
{
    public class LoginService
    {
        private readonly ApiClient _apiClient;

        public LoginService(ApiClient apiClient)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
        }

        public Task<LoginResponse> LoginAsync(LoginRequest request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));
            return _apiClient.PostAsync<LoginRequest, LoginResponse>("api/auth/login", request);
        }
    }
}
