using System;

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

    internal class CreateUserRequest
    {
        public string username { get; set; }
        public string password { get; set; }
        public string full_name { get; set; }
        public int role_id { get; set; }
        public string status { get; set; }
    }

    internal class UpdateUserRequest
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
