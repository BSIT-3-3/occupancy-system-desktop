namespace OccupancyMonitor.Models
{
    public class UserProfile
    {
        public int user_id { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string contact_number { get; set; }
    }

    public class UserRole
    {
        public int role_id { get; set; }
        public string role_name { get; set; }
        public string description { get; set; }
    }

    internal class UserWriteRequest
    {
        public string username { get; set; }
        public string password { get; set; }
        public string full_name { get; set; }
        public int role_id { get; set; }
        public string status { get; set; }
    }

    internal class UserProfileRequest
    {
        public int user_id { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string contact_number { get; set; }
    }
}
