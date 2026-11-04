using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkAssignment02.Models
{
    internal class Badge
    {
        public int BadgeId { get; set; }

        public string BadgeNumber { get; set; }

        public DateTime IssuedDate { get; set; }

        public BadgeTier Tier { get; set; }

        public int AttendeeId { get; set; }

        public Attendee Attendee { get; set; }
    }
}
