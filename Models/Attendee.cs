using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkAssignment02.Models
{
    internal class Attendee
    {
        public int AttendeeId { get; set; }

        [Required]
        [StringLength(150)]
        public string FullName { get; set; }

        [Required]
        [StringLength(200)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(150)]
        public string Street { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }

        [Required]
        [StringLength(100)]
        public string Country { get; set; }

        [Required]
        [StringLength(20)]
        [Column("ZipCode")]
        public string PostalCode { get; set; }

        [NotMapped]
        public string FullAddress =>
            $"{Street}, {City}, {Country}, {PostalCode}";


        public Badge? Badge { get; set; }
    }
}
