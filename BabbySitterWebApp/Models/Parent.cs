using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BabbySitter.Models
{
    // TODO: Child can have multiple Parents
    public class Parent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ParentId { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(255)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [StringLength(500)]
        public string Bio { get; set; }

        // Optional: Address details
        public string Address { get; set; }

        // Relationship with Booking (if one Parent can have many Bookings)
        public virtual ICollection<Booking> Bookings { get; set; }

        // Additional fields as necessary
    }
}
