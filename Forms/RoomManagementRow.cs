namespace OccupancyMonitor.Forms
{
    // Display projection used by the Room Management DataGridView.
    public sealed class RoomManagementRow
    {
        public int RoomId { get; set; }
        public string Room { get; set; }
        public string Device { get; set; }
        public string LastActivity { get; set; }
        public string Occupancy { get; set; }
        public string Status { get; set; }
    }
}
