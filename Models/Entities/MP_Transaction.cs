using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MP_Transaction")]
public partial class MP_Transaction
{
    [Key]
    public int Seq { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreateDate { get; set; }

    public long? MemberId { get; set; }

    public int? MP_ServiceId { get; set; }

    public int? PaymentTypeId { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? AmountToPay { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? BalanceBeforePay { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? BalanceAmount { get; set; }

    public int? Status { get; set; }

    public int? CreateBy { get; set; }

    public long? MUSavingLogId { get; set; }

    [Unicode(false)]
    public string? MPMemberDescription { get; set; }

    public int? TransactionStatusId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransactionDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PaymentReferenceCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PaymentResponseCode { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PaymentResponseMessage { get; set; }

    public long? TranId { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? FineAmount { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? NetAmount { get; set; }

    [ForeignKey("CreateBy")]
    [InverseProperty("MP_Transactions")]
    public virtual StaffUser? CreateByNavigation { get; set; }

    [ForeignKey("MP_ServiceId")]
    [InverseProperty("MP_Transactions")]
    public virtual MP_Service? MP_Service { get; set; }

    [ForeignKey("MUSavingLogId")]
    [InverseProperty("MP_Transactions")]
    public virtual MUSavingLog? MUSavingLog { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("MP_Transactions")]
    public virtual Member? Member { get; set; }

    [ForeignKey("PaymentTypeId")]
    [InverseProperty("MP_Transactions")]
    public virtual PaymentType? PaymentType { get; set; }

    [ForeignKey("TranId")]
    [InverseProperty("MP_Transactions")]
    public virtual Transaction? Tran { get; set; }

    [ForeignKey("TransactionStatusId")]
    [InverseProperty("MP_Transactions")]
    public virtual MP_TransactionStatus? TransactionStatus { get; set; }
}
