using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("TransactionCancel")]
public partial class TransactionCancel
{
    [Key]
    public long TranId { get; set; }

    public int TransactionStatusId { get; set; }

    public long MemberId { get; set; }

    [Unicode(false)]
    public string? LogeName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReservationsDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CancleDate { get; set; }

    public int? ReservationZoneId { get; set; }

    public int? ReservationSubZoneId { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("TransactionCancels")]
    public virtual Member Member { get; set; } = null!;

    [ForeignKey("ReservationSubZoneId")]
    [InverseProperty("TransactionCancels")]
    public virtual SubZone? ReservationSubZone { get; set; }

    [ForeignKey("TranId")]
    [InverseProperty("TransactionCancel")]
    public virtual Transaction Tran { get; set; } = null!;

    [ForeignKey("TransactionStatusId")]
    [InverseProperty("TransactionCancels")]
    public virtual TransactionStatus TransactionStatus { get; set; } = null!;
}
