using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("SubZoneId", "Day")]
[Table("LogeCostPerDay")]
public partial class LogeCostPerDay
{
    [Key]
    public int SubZoneId { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string Day { get; set; } = null!;

    public int Seq { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal Cost { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal? Cost2 { get; set; }

    [ForeignKey("SubZoneId")]
    [InverseProperty("LogeCostPerDays")]
    public virtual SubZone SubZone { get; set; } = null!;
}
