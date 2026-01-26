using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("RegularLogePaymentLog")]
public partial class RegularLogePaymentLog
{
    [Key]
    public long Id { get; set; }

    public long? InvoiceId { get; set; }

    public long? MemberId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LogeName { get; set; }

    public int? LogeQty { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? LogeAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? ElectricAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? WaterAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? MaintenanceFee { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? FineAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? AmountToPay { get; set; }

    public int? RegularLogeTypeId { get; set; }

    public int? PaymentTypeId { get; set; }

    public int? RegularLogePaymentTypeId { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Remark { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? TransactionStatusId { get; set; }

    public int? UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    [ForeignKey("InvoiceId")]
    [InverseProperty("RegularLogePaymentLogs")]
    public virtual RegularLoge_Invoice? Invoice { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("RegularLogePaymentLogs")]
    public virtual Member? Member { get; set; }

    [ForeignKey("PaymentTypeId")]
    [InverseProperty("RegularLogePaymentLogs")]
    public virtual PaymentType? PaymentType { get; set; }

    [ForeignKey("RegularLogeTypeId")]
    [InverseProperty("RegularLogePaymentLogs")]
    public virtual RegularLogePaymentType? RegularLogeType { get; set; }

    [ForeignKey("RegularLogeTypeId")]
    [InverseProperty("RegularLogePaymentLogs")]
    public virtual RegularLogeType? RegularLogeTypeNavigation { get; set; }

    [ForeignKey("TransactionStatusId")]
    [InverseProperty("RegularLogePaymentLogs")]
    public virtual RegularLoge_TransactionStatus? TransactionStatus { get; set; }
}
