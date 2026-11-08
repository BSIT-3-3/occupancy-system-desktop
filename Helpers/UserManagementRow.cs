using System;

namespace OccupancyMonitor.Forms
{
    // Projection used only to bind the joined user/profile/role data to the grid.
    public class UserManagementRow
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
