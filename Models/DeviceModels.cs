using System;

namespace OccupancyMonitor.Models
{
    // Mirrors the device.to_dict() response documented by the Flask API.
    public sealed class DeviceModel
    {
        public string device_id { get; set; }
        public int room_id { get; set; }
        public string device_code { get; set; }
        public string device_name { get; set; }
        public string registration_status { get; set; }
        public DateTimeOffset? registered_at { get; set; }
        public DeviceRoomModel room { get; set; }
    }

    public sealed class DeviceRoomModel
    {
        public int room_id { get; set; }
        public string room_number { get; set; }
        public string room_name { get; set; }
        public bool is_active { get; set; }
    }

    public sealed class DeviceCreateRequest
    {
        public string device_id { get; set; }
        public string device_code { get; set; }
        public string device_name { get; set; }
        public int room_id { get; set; }
    }

    public sealed class DeviceUpdateRequest
    {
        public string device_code { get; set; }
        public string device_name { get; set; }
        public int room_id { get; set; }
    }

    public sealed class DeviceUpdateWithStatusRequest
    {
        public string device_code { get; set; }
        public string device_name { get; set; }
        public int room_id { get; set; }
        public string registration_status { get; set; }
    }

    public sealed class DeviceDeactivationResponse
    {
        public string message { get; set; }
        public string device_id { get; set; }
    }
}
