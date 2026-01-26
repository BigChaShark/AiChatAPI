using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class SGSavingLog
{
    [Key]
    public long Seq { get; set; }

    public long MemberId { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal Amount { get; set; }

    public int SGSavingLogTypeId { get; set; }

    public long? TransactionId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdate { get; set; }

    [Column(TypeName = "numeric(9, 0)")]
    public decimal? AmountBalance { get; set; }

    public long? ReservationLogeId { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? StaffUserId { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LogeName { get; set; }

    [Unicode(false)]
    public string? TroubleshootingLog { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal? BonusAmount { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal? BeforeBonusAmount { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("SGSavingLogs")]
    public virtual Member Member { get; set; } = null!;

    [ForeignKey("SGSavingLogTypeId")]
    [InverseProperty("SGSavingLogs")]
    public virtual SGSavingLogType SGSavingLogType { get; set; } = null!;

    [ForeignKey("StaffUserId")]
    [InverseProperty("SGSavingLogs")]
    public virtual StaffUser? StaffUser { get; set; }

    [ForeignKey("TransactionId")]
    [InverseProperty("SGSavingLogs")]
    public virtual Transaction? Transaction { get; set; }
}
