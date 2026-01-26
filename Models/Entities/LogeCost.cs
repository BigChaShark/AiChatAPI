using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("Day", "LogeId")]
[Table("LogeCost")]
public partial class LogeCost
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string Day { get; set; } = null!;

    [Key]
    public int LogeId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Amount { get; set; }

    [ForeignKey("LogeId")]
    [InverseProperty("LogeCosts")]
    public virtual Loge Loge { get; set; } = null!;
}
