using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FreshMarketTransaction")]
public partial class FreshMarketTransaction
{
    [Key]
    public long TranId { get; set; }

    public int? TransactionStatusId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TranCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MemberId { get; set; }

    public int? PaymentGatewayId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? PaymentEndPointUrl { get; set; }

    public long? ReservationLogeId { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal? AmountToPay { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

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

    [StringLength(10)]
    [Unicode(false)]
    public string? RcptNo { get; set; }

    public int? ReservationLogeTypeId { get; set; }

    public int? ReservationLogeElectricityTypeId { get; set; }

    public int? ReservationLogeElectronicTypeId { get; set; }

    public int? ReservationSubZoneId { get; set; }

    public int? StaffUserId { get; set; }

    public int? TransactionTypeId { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string? IDCard { get; set; }
}
