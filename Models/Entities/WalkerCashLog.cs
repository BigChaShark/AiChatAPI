using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("WalkerCashLog")]
public partial class WalkerCashLog
{
    [Key]
    public long Id { get; set; }

    public long? WalkerId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TranDate { get; set; }

    public int? TranType { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Amount { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? Status { get; set; }
}
