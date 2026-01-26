using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("ReservationLoge")]
public partial class ReservationLoge
{
    [Key]
    public long Id { get; set; }

    public long MemberId { get; set; }

    public int? ZoneId { get; set; }

    public int LogeQty { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string LogeName { get; set; } = null!;

    [Column(TypeName = "decimal(9, 2)")]
    public decimal LogeAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal ElectricityAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal ElectronicAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal DiscountAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal TotalAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal FullAreaAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal FineAmount { get; set; }

    public int Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreateDate { get; set; }

    public int? SubZoneId { get; set; }

    public int? IsEntrance { get; set; }

    public int? ReservationStatus { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? SavingAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PaymentFee { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? EStampAmount { get; set; }

    [InverseProperty("ReservationLoge")]
    public virtual ICollection<CheckInTopupLog> CheckInTopupLogs { get; set; } = new List<CheckInTopupLog>();

    [InverseProperty("ReservationLoge")]
    public virtual CheckLogeAbsence? CheckLogeAbsence { get; set; }

    [InverseProperty("ReservationLoge")]
    public virtual ICollection<MUSavingLog> MUSavingLogs { get; set; } = new List<MUSavingLog>();

    [ForeignKey("MemberId")]
    [InverseProperty("ReservationLoges")]
    public virtual Member Member { get; set; } = null!;

    [InverseProperty("ReservationLoge")]
    public virtual ICollection<MemberCoupon> MemberCoupons { get; set; } = new List<MemberCoupon>();

    [InverseProperty("ReservationLoge")]
    public virtual ICollection<QueueSMSSending> QueueSMSSendings { get; set; } = new List<QueueSMSSending>();

    [InverseProperty("ReservationLoge")]
    public virtual ICollection<ReservationLogeAdditional> ReservationLogeAdditionals { get; set; } = new List<ReservationLogeAdditional>();

    [InverseProperty("ReservationLoge")]
    public virtual ICollection<ReservationLogeDetail> ReservationLogeDetails { get; set; } = new List<ReservationLogeDetail>();

    [InverseProperty("ReservationLoge")]
    public virtual ICollection<SavingReceive> SavingReceives { get; set; } = new List<SavingReceive>();

    [ForeignKey("SubZoneId")]
    [InverseProperty("ReservationLoges")]
    public virtual SubZone? SubZone { get; set; }

    [InverseProperty("ReservationLoge")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    [InverseProperty("ReservationLoge")]
    public virtual ICollection<WalletLog> WalletLogs { get; set; } = new List<WalletLog>();

    [ForeignKey("ZoneId")]
    [InverseProperty("ReservationLoges")]
    public virtual Zone? Zone { get; set; }
}
