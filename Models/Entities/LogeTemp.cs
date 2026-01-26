using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("LogeTemp")]
public partial class LogeTemp
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal Seq { get; set; }

    public int LogeId { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string LogeName { get; set; } = null!;

    public DateOnly OpenDateInt { get; set; }

    public int LogeTypeId { get; set; }

    public int LogeIndex { get; set; }

    public int IsConner { get; set; }

    public int Status { get; set; }

    [ForeignKey("LogeId")]
    [InverseProperty("LogeTemps")]
    public virtual Loge Loge { get; set; } = null!;

    [ForeignKey("LogeTypeId")]
    [InverseProperty("LogeTemps")]
    public virtual LogeType LogeType { get; set; } = null!;
}
