using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class SGPointLog
{
    [Key]
    public long Seq { get; set; }

    public long MemberId { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal Amount { get; set; }

    public int SGPointLogTypeId { get; set; }

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
    [InverseProperty("SGPointLogs")]
    public virtual Member Member { get; set; } = null!;

    [ForeignKey("SGPointLogTypeId")]
    [InverseProperty("SGPointLogs")]
    public virtual SGPointLogType SGPointLogType { get; set; } = null!;

    [ForeignKey("StaffUserId")]
    [InverseProperty("SGPointLogs")]
    public virtual StaffUser? StaffUser { get; set; }
}
