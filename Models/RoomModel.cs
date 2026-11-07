using System;

namespace OccupancyMonitor.Models
{
    // Mirrors Room.to_dict() from the Flask API.
    public sealed class RoomModel
    {
        public int room_id { get; set; }
        public string room_number { get; set; }
        public string room_name { get; set; }
        public string occupancy_status { get; set; }
        public DateTimeOffset? last_occupancy_update { get; set; }
        public bool is_active { get; set; }
    }

    public sealed class RoomWriteRequest
    {
        public string room_number { get; set; }
        public string room_name { get; set; }
        public bool is_active { get; set; }
    }

    public sealed class RoomDeactivationResponse
    {
        public string message { get; set; }
        public int room_id { get; set; }
    }
}
