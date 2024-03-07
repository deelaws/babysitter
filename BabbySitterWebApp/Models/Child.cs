using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BabbySitter.Models
{
    public class Child
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ChildId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [StringLength(500)]
        public string SpecialRequirements { get; set; }

        // Foreign key for Parent
        public int ParentId { get; set; }

        // Navigation property
        [ForeignKey("ParentId")]
        public virtual Parent Parent { get; set; }
    }
}
