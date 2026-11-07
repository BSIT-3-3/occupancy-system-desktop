using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OccupancyMonitor.Models;

namespace OccupancyMonitor.Services
{
    public sealed class DeviceService
    {
        private readonly ApiClient _apiClient;

        public DeviceService(ApiClient apiClient)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
        }

        public Task<List<DeviceModel>> GetDevicesAsync(string accessToken)
        {
            return _apiClient.GetAsync<List<DeviceModel>>("devices", accessToken);
        }

        public Task<List<RoomModel>> GetAvailableRoomsAsync(string accessToken)
        {
            return _apiClient.GetAsync<List<RoomModel>>("devices/available-rooms", accessToken);
        }

        public Task<DeviceModel> GetDeviceAsync(string deviceId, string accessToken)
        {
            return _apiClient.GetAsync<DeviceModel>("devices/" + Uri.EscapeDataString(deviceId), accessToken);
        }

        public Task<DeviceModel> CreateDeviceAsync(DeviceCreateRequest request, string accessToken)
        {
            return _apiClient.PostAsync<DeviceCreateRequest, DeviceModel>("devices", request, accessToken);
        }

        public Task<DeviceModel> UpdateDeviceAsync(string deviceId, DeviceUpdateRequest request, string accessToken)
        {
            return _apiClient.PutAsync<DeviceUpdateRequest, DeviceModel>("devices/" + Uri.EscapeDataString(deviceId), request, accessToken);
        }

        public Task<DeviceModel> UpdateDeviceWithStatusAsync(string deviceId, DeviceUpdateWithStatusRequest request, string accessToken)
        {
            return _apiClient.PutAsync<DeviceUpdateWithStatusRequest, DeviceModel>("devices/" + Uri.EscapeDataString(deviceId), request, accessToken);
        }

        public Task<DeviceDeactivationResponse> DeactivateDeviceAsync(string deviceId, string accessToken)
        {
            return _apiClient.DeleteAsync<DeviceDeactivationResponse>("devices/" + Uri.EscapeDataString(deviceId), accessToken);
        }
    }
}
