using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("SubZoneId", "LogeId", "Day")]
[Table("LogeCostMX")]
public partial class LogeCostMX
{
    [Key]
    public int SubZoneId { get; set; }

    [Key]
    public int LogeId { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string Day { get; set; } = null!;

    public int Seq { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal Cost { get; set; }

    [ForeignKey("LogeId")]
    [InverseProperty("LogeCostMXes")]
    public virtual Loge Loge { get; set; } = null!;

    [ForeignKey("SubZoneId")]
    [InverseProperty("LogeCostMXes")]
    public virtual SubZone SubZone { get; set; } = null!;
}
