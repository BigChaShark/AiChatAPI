using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("OutStandingDebtLog")]
public partial class OutStandingDebtLog
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

    [ForeignKey("UpdateBy")]
    [InverseProperty("OutStandingDebtLogs")]
    public virtual StaffUser? UpdateByNavigation { get; set; }
}
