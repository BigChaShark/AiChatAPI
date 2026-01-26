using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("ZoneId", "TypeId")]
[Table("LogeCostByType")]
public partial class LogeCostByType
{
    [Key]
    public int ZoneId { get; set; }

    [Key]
    public int TypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Day { get; set; }

    public int? Seq { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal? Cost { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal? Cost2 { get; set; }

    [ForeignKey("ZoneId")]
    [InverseProperty("LogeCostByTypes")]
    public virtual Zone Zone { get; set; } = null!;
}
