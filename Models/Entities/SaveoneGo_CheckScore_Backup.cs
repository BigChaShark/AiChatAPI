using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_CheckScore_Backup")]
public partial class SaveoneGo_CheckScore_Backup
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "decimal(2, 0)")]
    public decimal? Condition1 { get; set; }

    [Column(TypeName = "decimal(2, 0)")]
    public decimal? Condition2 { get; set; }

    [Column(TypeName = "decimal(2, 0)")]
    public decimal? Condition3 { get; set; }

    [Column(TypeName = "decimal(2, 0)")]
    public decimal? Condition4 { get; set; }

    [Column(TypeName = "decimal(2, 0)")]
    public decimal? Condition5 { get; set; }

    [Column(TypeName = "decimal(2, 0)")]
    public decimal? Condition6 { get; set; }

    [Column(TypeName = "decimal(2, 0)")]
    public decimal? Condition7 { get; set; }

    [Column(TypeName = "decimal(2, 0)")]
    public decimal? Condition8 { get; set; }

    [Column(TypeName = "decimal(2, 0)")]
    public decimal? Condition9 { get; set; }

    [Column(TypeName = "decimal(2, 0)")]
    public decimal? Condition10 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    public long? TransactionId { get; set; }

    public int? SaveoneGo_ZoneMarketId { get; set; }
}
