using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Keyless]
public partial class View_1
{
    public long TranId { get; set; }

    public int TransactionStatusId { get; set; }

    public long MemberId { get; set; }

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

    [StringLength(500)]
    [Unicode(false)]
    public string? PaymentResponseMessage { get; set; }

    public int? PaymentTypeId { get; set; }

    public int? BypassPaymentStatusId { get; set; }

    public int? ReservationSubZoneId { get; set; }
}
