using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkAssignment02.Models
{
    internal class OrganizerProfile
    {
        public int OrganizerProfileId { get; set; }

        public string Bio { get; set; }

        public string WebsiteUrl { get; set; }

        public string LogoUrl { get; set; }

        public int OrganizerId { get; set; }

        public Organizer Organizer { get; set; }
    }
}
