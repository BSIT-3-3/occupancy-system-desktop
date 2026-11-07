using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccupancyMonitor.Models
{
    public class LoginRequest
    {
        public string username { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
    }

    public class LoginResponse
    {
        public string message { get; set; } = string.Empty;
        public LoginUser User { get; set; }
        public string access_token { get; set; } = string.Empty;
        public string refresh_token { get; set; } = string.Empty;
        public DateTime access_token_expires_at { get; set; }
        public DateTime refresh_token_expires_at { get; set; }
        public int session_id { get; set; }
    }


    public class LoginUser
    {
        public int User_Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Full_Name { get; set; } = null;
        public int Role_Id { get; set; }
        public string Status { get; set; } = string.Empty;
    }

}


