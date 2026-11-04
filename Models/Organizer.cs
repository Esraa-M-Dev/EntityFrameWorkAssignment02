using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkAssignment02.Models
{
    [Table("EventOrganizers")]
    internal class Organizer
    {
        
        public int OrganizerId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(150)]
        public string? CompanyName { get; set; }

        public OrganizerProfile? Profile { get; set; }

        public ICollection<Event> Events { get; set; }= new List<Event>();
    }
}

