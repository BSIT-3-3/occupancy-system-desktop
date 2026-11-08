namespace OccupancyMonitor.Models
{
    /// <summary>
    /// Summary returned by GET /api/device-monitoring/summary.
    /// Counts cover registered devices; active_count is limited to devices
    /// assigned to active rooms.
    /// </summary>
    public sealed class DeviceMonitoringSummary
    {
        public int? registered_count { get; set; }
        public int? active_count { get; set; }
        public int? online_count { get; set; }
        public int? offline_count { get; set; }
        public int? unknown_count { get; set; }
    }
}
