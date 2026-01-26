using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("Transaction_Backup")]
public partial class Transaction_Backup
{
    [Key]
    public long TranId { get; set; }

    public int TransactionStatusId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string TranCode { get; set; } = null!;

    public long MemberId { get; set; }

    public int PaymentGatewayId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? PaymentEndPointUrl { get; set; }

    public long? ReservationLogeId { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal AmountToPay { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreateDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PaymentDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReservationsDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CancleDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PaymentReferenceCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PaymentResponseCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PaymentResponseMessage { get; set; }

    public int? PaymentTypeId { get; set; }

    public int? RcptType { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RcptNo { get; set; }

    public int? ReservationLogeTypeId { get; set; }

    public int? ReservationLogeElectricityTypeId { get; set; }

    public int? ReservationLogeElectronicTypeId { get; set; }

    public int? ReservationSubZoneId { get; set; }

    public int? StaffUserId { get; set; }

    public int? TransactionTypeId { get; set; }

    public int? TransactionSubZoneId { get; set; }

    public int? BypassPaymentStatusId { get; set; }

    public int? IsAddLogeAuto { get; set; }

    public int? ChangeReservationSubZoneId { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ReservationsResult { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReservationsRound { get; set; }

    public int? CancelStaffUserId { get; set; }

    public int? ChangeLogeStaffUserId { get; set; }

    public int? ChangeElecStaffUserId { get; set; }

    public int? IsHelpDesk { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? IsBillVat { get; set; }

    public int? LogeId { get; set; }

    /// <summary>
    /// null = ไม่มีส่วนลด | 1 = บันทึกส่วนลดฝนตก | 2 = บันทึกส่วนลดฝนตก (free day)
    /// </summary>
    public int? IsDiscountRain { get; set; }

    /// <summary>
    /// null = ไม่มีส่วนลด | 1 = บันทึกส่วนลดฝนตก | 2 = บันทึกส่วนลดฝนตก (free day)
    /// </summary>
    public int? IsDiscountRain_FreeDay { get; set; }

    public long? IsRefundMuSaving { get; set; }

    public long? IsRefundWallet { get; set; }

    public int? IsGuest { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? RcptCode { get; set; }

    public int? isChangeZone { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? RcptCode2 { get; set; }

    [ForeignKey("CancelStaffUserId")]
    [InverseProperty("Transaction_BackupCancelStaffUsers")]
    public virtual StaffUser? CancelStaffUser { get; set; }

    [ForeignKey("ChangeElecStaffUserId")]
    [InverseProperty("Transaction_BackupChangeElecStaffUsers")]
    public virtual StaffUser? ChangeElecStaffUser { get; set; }

    [ForeignKey("ChangeLogeStaffUserId")]
    [InverseProperty("Transaction_BackupChangeLogeStaffUsers")]
    public virtual StaffUser? ChangeLogeStaffUser { get; set; }

    [ForeignKey("ChangeReservationSubZoneId")]
    [InverseProperty("Transaction_BackupChangeReservationSubZones")]
    public virtual SubZone? ChangeReservationSubZone { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("Transaction_Backups")]
    public virtual Member Member { get; set; } = null!;

    [ForeignKey("PaymentGatewayId")]
    [InverseProperty("Transaction_Backups")]
    public virtual PaymentGateway PaymentGateway { get; set; } = null!;

    [ForeignKey("PaymentTypeId")]
    [InverseProperty("Transaction_Backups")]
    public virtual PaymentType? PaymentType { get; set; }

    [ForeignKey("RcptType")]
    [InverseProperty("Transaction_Backups")]
    public virtual ReceiptType? RcptTypeNavigation { get; set; }

    [ForeignKey("ReservationLogeElectricityTypeId")]
    [InverseProperty("Transaction_Backups")]
    public virtual ReservationLogeElectricityType? ReservationLogeElectricityType { get; set; }

    [ForeignKey("ReservationLogeElectronicTypeId")]
    [InverseProperty("Transaction_Backups")]
    public virtual ReservationLogeElectronicType? ReservationLogeElectronicType { get; set; }

    [ForeignKey("ReservationLogeTypeId")]
    [InverseProperty("Transaction_Backups")]
    public virtual ReservationLogeType? ReservationLogeType { get; set; }

    [ForeignKey("ReservationSubZoneId")]
    [InverseProperty("Transaction_BackupReservationSubZones")]
    public virtual SubZone? ReservationSubZone { get; set; }

    [ForeignKey("StaffUserId")]
    [InverseProperty("Transaction_BackupStaffUsers")]
    public virtual StaffUser? StaffUser { get; set; }

    [ForeignKey("TransactionStatusId")]
    [InverseProperty("Transaction_Backups")]
    public virtual TransactionStatus TransactionStatus { get; set; } = null!;

    [ForeignKey("TransactionTypeId")]
    [InverseProperty("Transaction_Backups")]
    public virtual TransactionType? TransactionType { get; set; }
}
