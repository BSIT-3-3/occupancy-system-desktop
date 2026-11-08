using System;
using System.Threading.Tasks;
using OccupancyMonitor.Models;

namespace OccupancyMonitor.Services
{
    public sealed class DeviceMonitoringService
    {
        private readonly ApiClient _apiClient;

        public DeviceMonitoringService(ApiClient apiClient)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
        }

        public Task<DeviceMonitoringSummary> GetSummaryAsync(string accessToken)
        {
            return _apiClient.GetAsync<DeviceMonitoringSummary>(
                "api/device-monitoring/summary", accessToken);
        }
    }
}
