using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BabbySitter.Models;

// If you include relationships, define those models as well. Example:
public class Review
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ReviewId { get; set; }

    [Required]
    public int BabysitterId { get; set; }

    public virtual Babysitter Babysitter { get; set; }

    [Required]
    public int Rating { get; set; }

    [StringLength(1000)]
    public string Comment { get; set; }

    [Required]
    public DateTime ReviewDate { get; set; }
}
