using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("QueueSMSSending")]
public partial class QueueSMSSending
{
    [Key]
    public long Seq { get; set; }

    public long MemberId { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal Amount { get; set; }

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

    [Unicode(false)]
    public string? SMSMessage { get; set; }

    public int? app_noti { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("QueueSMSSendings")]
    public virtual Member Member { get; set; } = null!;

    [ForeignKey("ReservationLogeId")]
    [InverseProperty("QueueSMSSendings")]
    public virtual ReservationLoge? ReservationLoge { get; set; }

    [ForeignKey("StaffUserId")]
    [InverseProperty("QueueSMSSendings")]
    public virtual StaffUser? StaffUser { get; set; }

    [ForeignKey("TransactionId")]
    [InverseProperty("QueueSMSSendings")]
    public virtual Transaction? Transaction { get; set; }
}
