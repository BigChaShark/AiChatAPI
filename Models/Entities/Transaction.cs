using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

/// <summary>
/// RPI = Request Payment Input
/// RPO = Request Payment Output
/// PRN = Payment result for HTTP post parameter
/// PRS =  Payment result for respUrl (Silent Post)
/// </summary>
[Table("Transaction")]
[Index("TranCode", Name = "IX_Transaction", IsUnique = true)]
public partial class Transaction
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

    public int? isUseGoPoint { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal GoPointUse { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal GoPointRecieve { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SellingDate { get; set; }

    [InverseProperty("Transaction")]
    public virtual ICollection<Absence> Absences { get; set; } = new List<Absence>();

    [ForeignKey("BypassPaymentStatusId")]
    [InverseProperty("Transactions")]
    public virtual BypassPaymentStatus? BypassPaymentStatus { get; set; }

    [ForeignKey("CancelStaffUserId")]
    [InverseProperty("TransactionCancelStaffUsers")]
    public virtual StaffUser? CancelStaffUser { get; set; }

    [ForeignKey("ChangeElecStaffUserId")]
    [InverseProperty("TransactionChangeElecStaffUsers")]
    public virtual StaffUser? ChangeElecStaffUser { get; set; }

    [ForeignKey("ChangeLogeStaffUserId")]
    [InverseProperty("TransactionChangeLogeStaffUsers")]
    public virtual StaffUser? ChangeLogeStaffUser { get; set; }

    [ForeignKey("ChangeReservationSubZoneId")]
    [InverseProperty("TransactionChangeReservationSubZones")]
    public virtual SubZone? ChangeReservationSubZone { get; set; }

    [InverseProperty("Tran")]
    public virtual ICollection<CheckInLog> CheckInLogs { get; set; } = new List<CheckInLog>();

    [ForeignKey("LogeId")]
    [InverseProperty("Transactions")]
    public virtual Loge? Loge { get; set; }

    [InverseProperty("Transaction")]
    public virtual ICollection<LogicWorkLog> LogicWorkLogs { get; set; } = new List<LogicWorkLog>();

    [InverseProperty("Tran")]
    public virtual ICollection<LowerLogeLog> LowerLogeLogs { get; set; } = new List<LowerLogeLog>();

    [InverseProperty("Tran")]
    public virtual ICollection<MP_Transaction> MP_Transactions { get; set; } = new List<MP_Transaction>();

    [InverseProperty("Transaction")]
    public virtual ICollection<MUSavingLog> MUSavingLogs { get; set; } = new List<MUSavingLog>();

    [ForeignKey("MemberId")]
    [InverseProperty("Transactions")]
    public virtual Member Member { get; set; } = null!;

    [InverseProperty("Tran")]
    public virtual ICollection<MemberLeave> MemberLeaves { get; set; } = new List<MemberLeave>();

    [ForeignKey("PaymentGatewayId")]
    [InverseProperty("Transactions")]
    public virtual PaymentGateway PaymentGateway { get; set; } = null!;

    [InverseProperty("Transaction")]
    public virtual ICollection<PaymentLog> PaymentLogs { get; set; } = new List<PaymentLog>();

    [InverseProperty("Tran")]
    public virtual ICollection<PaymentOverWallet> PaymentOverWallets { get; set; } = new List<PaymentOverWallet>();

    [ForeignKey("PaymentTypeId")]
    [InverseProperty("Transactions")]
    public virtual PaymentType? PaymentType { get; set; }

    [InverseProperty("Transaction")]
    public virtual ICollection<QueueSMSSending> QueueSMSSendings { get; set; } = new List<QueueSMSSending>();

    [ForeignKey("RcptType")]
    [InverseProperty("Transactions")]
    public virtual ReceiptType? RcptTypeNavigation { get; set; }

    [InverseProperty("Tran")]
    public virtual ICollection<ReceiptLog> ReceiptLogs { get; set; } = new List<ReceiptLog>();

    [InverseProperty("Tran")]
    public virtual ICollection<ReprintLog> ReprintLogs { get; set; } = new List<ReprintLog>();

    [ForeignKey("ReservationLogeId")]
    [InverseProperty("Transactions")]
    public virtual ReservationLoge? ReservationLoge { get; set; }

    [ForeignKey("ReservationLogeElectricityTypeId")]
    [InverseProperty("Transactions")]
    public virtual ReservationLogeElectricityType? ReservationLogeElectricityType { get; set; }

    [ForeignKey("ReservationLogeElectronicTypeId")]
    [InverseProperty("Transactions")]
    public virtual ReservationLogeElectronicType? ReservationLogeElectronicType { get; set; }

    [InverseProperty("Tran")]
    public virtual ICollection<ReservationLogeMx> ReservationLogeMxes { get; set; } = new List<ReservationLogeMx>();

    [ForeignKey("ReservationLogeTypeId")]
    [InverseProperty("Transactions")]
    public virtual ReservationLogeType? ReservationLogeType { get; set; }

    [ForeignKey("ReservationSubZoneId")]
    [InverseProperty("TransactionReservationSubZones")]
    public virtual SubZone? ReservationSubZone { get; set; }

    [InverseProperty("Tran")]
    public virtual ICollection<SCBQrcodePayment> SCBQrcodePayments { get; set; } = new List<SCBQrcodePayment>();

    [InverseProperty("Transaction")]
    public virtual ICollection<SGSavingLog> SGSavingLogs { get; set; } = new List<SGSavingLog>();

    [InverseProperty("Transaction")]
    public virtual ICollection<SaveonGO_TransactionGetLogeNoPaid> SaveonGO_TransactionGetLogeNoPaids { get; set; } = new List<SaveonGO_TransactionGetLogeNoPaid>();

    [InverseProperty("Transaction")]
    public virtual ICollection<SaveoneGo_Blacklist> SaveoneGo_Blacklists { get; set; } = new List<SaveoneGo_Blacklist>();

    [InverseProperty("Transaction")]
    public virtual ICollection<SaveoneGo_CheckScoreSpecial> SaveoneGo_CheckScoreSpecials { get; set; } = new List<SaveoneGo_CheckScoreSpecial>();

    [InverseProperty("Transaction")]
    public virtual ICollection<SaveoneGo_CheckScore> SaveoneGo_CheckScores { get; set; } = new List<SaveoneGo_CheckScore>();

    [InverseProperty("New_Transaction")]
    public virtual ICollection<SaveoneGo_Fine> SaveoneGo_FineNew_Transactions { get; set; } = new List<SaveoneGo_Fine>();

    [InverseProperty("Transaction")]
    public virtual ICollection<SaveoneGo_Fine> SaveoneGo_FineTransactions { get; set; } = new List<SaveoneGo_Fine>();

    [ForeignKey("StaffUserId")]
    [InverseProperty("TransactionStaffUsers")]
    public virtual StaffUser? StaffUser { get; set; }

    [InverseProperty("Tran")]
    public virtual TransactionCancel? TransactionCancel { get; set; }

    [InverseProperty("Transaction")]
    public virtual ICollection<TransactionDetail> TransactionDetails { get; set; } = new List<TransactionDetail>();

    [ForeignKey("TransactionStatusId")]
    [InverseProperty("Transactions")]
    public virtual TransactionStatus TransactionStatus { get; set; } = null!;

    [InverseProperty("Tran")]
    public virtual ICollection<TransactionTaxRcpt> TransactionTaxRcpts { get; set; } = new List<TransactionTaxRcpt>();

    [ForeignKey("TransactionTypeId")]
    [InverseProperty("Transactions")]
    public virtual TransactionType? TransactionType { get; set; }

    [InverseProperty("Transaction")]
    public virtual ICollection<WalletLog> WalletLogs { get; set; } = new List<WalletLog>();

    [InverseProperty("Transaction")]
    public virtual ICollection<saveonGO_TransactionReturn> saveonGO_TransactionReturns { get; set; } = new List<saveonGO_TransactionReturn>();
}
