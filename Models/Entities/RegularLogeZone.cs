using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("RegularLogeZone")]
public partial class RegularLogeZone
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Description { get; set; }

    public int? Status { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Color { get; set; }

    [InverseProperty("Zone")]
    public virtual ICollection<RegularLoge> RegularLoges { get; set; } = new List<RegularLoge>();
}
