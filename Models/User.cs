using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccupancyMonitor.Models
{
    public class User
    {
        public int user_id { get; set; }
        public string username { get; set; }
        public string full_name { get; set; }
        public int role_id { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
    }
}
