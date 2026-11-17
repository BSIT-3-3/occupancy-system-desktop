using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccupancyMonitor.Helpers
{
    class DeviceManagementRow
    {
        public string DeviceId { get; set; }
        public string DeviceCode { get; set; }
        public string DeviceName { get; set; }
        public string Room { get; set; }
        public string RegistrationStatus{ get; set; }
        public string RegisteredAt { get; set; }

    }
}
