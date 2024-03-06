using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BabbySitter.Models;

public class Certificate
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CertificateId { get; set; }

    [Required]
    [StringLength(150)]
    public string Title { get; set; }

    [StringLength(500)]
    public string Description { get; set; }

    [Required]
    public DateTime DateIssued { get; set; }

    [StringLength(100)]
    public string IssuingOrganization { get; set; }

    // Foreign key
    public int BabysitterId { get; set; }

    // Navigation property
    public virtual Babysitter Babysitter { get; set; }
}

