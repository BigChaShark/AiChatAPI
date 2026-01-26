using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MP_Transaction_Backup")]
public partial class MP_Transaction_Backup
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
}
