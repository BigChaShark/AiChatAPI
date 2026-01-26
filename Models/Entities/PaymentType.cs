using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("PaymentType")]
public partial class PaymentType
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public int Status { get; set; }

    [InverseProperty("PaymentType")]
    public virtual ICollection<AdvanceReservation> AdvanceReservations { get; set; } = new List<AdvanceReservation>();

    [InverseProperty("PaymentType")]
    public virtual ICollection<DeliveryTransaction> DeliveryTransactions { get; set; } = new List<DeliveryTransaction>();

    [InverseProperty("PaymentType")]
    public virtual ICollection<MP_Member> MP_Members { get; set; } = new List<MP_Member>();

    [InverseProperty("PaymentType")]
    public virtual ICollection<MP_Transaction> MP_Transactions { get; set; } = new List<MP_Transaction>();

    [InverseProperty("PaymentType")]
    public virtual ICollection<PaymentLog> PaymentLogs { get; set; } = new List<PaymentLog>();

    [InverseProperty("PaymentType")]
    public virtual ICollection<RegularLogePaymentLog> RegularLogePaymentLogs { get; set; } = new List<RegularLogePaymentLog>();

    [InverseProperty("PaymentType")]
    public virtual ICollection<RegularLoge> RegularLoges { get; set; } = new List<RegularLoge>();

    [InverseProperty("PaymentType")]
    public virtual ICollection<Transaction_Backup> Transaction_Backups { get; set; } = new List<Transaction_Backup>();

    [InverseProperty("PaymentType")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
