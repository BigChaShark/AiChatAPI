using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MUSavingLog")]
public partial class MUSavingLog
{
    [Key]
    public long Seq { get; set; }

    public long MemberId { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal Amount { get; set; }

    public int MUSavingLogTypeId { get; set; }

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

    [InverseProperty("MUSavingLog")]
    public virtual ICollection<MP_Transaction> MP_Transactions { get; set; } = new List<MP_Transaction>();

    [ForeignKey("MUSavingLogTypeId")]
    [InverseProperty("MUSavingLogs")]
    public virtual MUSavingLogType MUSavingLogType { get; set; } = null!;

    [ForeignKey("MemberId")]
    [InverseProperty("MUSavingLogs")]
    public virtual Member Member { get; set; } = null!;

    [ForeignKey("ReservationLogeId")]
    [InverseProperty("MUSavingLogs")]
    public virtual ReservationLoge? ReservationLoge { get; set; }

    [ForeignKey("StaffUserId")]
    [InverseProperty("MUSavingLogs")]
    public virtual StaffUser? StaffUser { get; set; }

    [ForeignKey("TransactionId")]
    [InverseProperty("MUSavingLogs")]
    public virtual Transaction? Transaction { get; set; }
}
