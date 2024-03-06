using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BabbySitter.Models
{
    public class Babysitter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BabysitterId { get; set; }

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

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public int YearsOfExperience { get; set; }

        [Required]
        public decimal HourlyRate { get; set; }

        // Consider adding a Location or Address property if needed
        // public string Location { get; set; }

        // Relationships - Example if you have ratings or reviews for babysitters
        public virtual ICollection<Review> Reviews { get; set; }

        // Additional properties like Certifications, Skills, etc.
        public virtual ICollection<Certificate> Certifications { get; set; }
    }
}
