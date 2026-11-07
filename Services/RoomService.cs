using System.Collections.Generic;
using System.Threading.Tasks;
using OccupancyMonitor.Models;

namespace OccupancyMonitor.Services
{
    public sealed class RoomService
    {
        private readonly ApiClient _apiClient;

        public RoomService(ApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Task<List<RoomModel>> GetRoomsAsync(string accessToken)
        {
            return _apiClient.GetAsync<List<RoomModel>>("rooms", accessToken);
        }

        public Task<RoomModel> GetRoomAsync(int roomId, string accessToken)
        {
            return _apiClient.GetAsync<RoomModel>("rooms/" + roomId, accessToken);
        }

        public Task<RoomModel> CreateRoomAsync(RoomWriteRequest request, string accessToken)
        {
            return _apiClient.PostAsync<RoomWriteRequest, RoomModel>("rooms", request, accessToken);
        }

        public Task<RoomModel> UpdateRoomAsync(int roomId, RoomWriteRequest request, string accessToken)
        {
            return _apiClient.PutAsync<RoomWriteRequest, RoomModel>("rooms/" + roomId, request, accessToken);
        }

        public Task<RoomDeactivationResponse> DeactivateRoomAsync(int roomId, string accessToken)
        {
            return _apiClient.DeleteAsync<RoomDeactivationResponse>("rooms/" + roomId, accessToken);
        }
    }
}
