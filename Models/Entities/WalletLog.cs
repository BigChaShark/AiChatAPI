using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("WalletLog")]
public partial class WalletLog
{
    [Key]
    public long Seq { get; set; }

    public long MemberId { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal Amount { get; set; }

    public int WalletLogTypeId { get; set; }

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

    [Unicode(false)]
    public string? TroubleshootingLog { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("WalletLogs")]
    public virtual Member Member { get; set; } = null!;

    [ForeignKey("ReservationLogeId")]
    [InverseProperty("WalletLogs")]
    public virtual ReservationLoge? ReservationLoge { get; set; }

    [ForeignKey("StaffUserId")]
    [InverseProperty("WalletLogs")]
    public virtual StaffUser? StaffUser { get; set; }

    [ForeignKey("TransactionId")]
    [InverseProperty("WalletLogs")]
    public virtual Transaction? Transaction { get; set; }

    [ForeignKey("WalletLogTypeId")]
    [InverseProperty("WalletLogs")]
    public virtual WalletLogType WalletLogType { get; set; } = null!;
}
