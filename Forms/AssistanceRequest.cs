using System;

namespace UI3AssistanceRequests
{
    public class AssistanceRequest
    {
        public string RequestId { get; set; }
        public string Room { get; set; }
        public string Subject { get; set; }
        public string RequestedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string StaffUpdate { get; set; }
    }
}
