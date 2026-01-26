using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class ERPOperation
{
    [Key]
    public long ERPTransactionId { get; set; }

    public int? MaintainResult { get; set; }

    public int? ElectricResult { get; set; }

    public int? ElectricWatt { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ElectricAmount { get; set; }

    public int? WaterResult { get; set; }

    public int? WaterUnit { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? WaterAmount { get; set; }

    [ForeignKey("ERPTransactionId")]
    [InverseProperty("ERPOperation")]
    public virtual ERPTransaction ERPTransaction { get; set; } = null!;
}
