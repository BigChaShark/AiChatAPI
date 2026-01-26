using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("OutStanding")]
public partial class OutStanding
{
    [Key]
    public long Seq { get; set; }

    public int? OutstandingDebtId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TransferDate { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? OutstandingAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Amount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? BalanceAmount { get; set; }

    public int? UpdateBy { get; set; }
}
