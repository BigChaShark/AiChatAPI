using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("BypassPaymentStatus")]
public partial class BypassPaymentStatus
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public int Status { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PaymentStatus { get; set; }

    [InverseProperty("BypassPaymentStatus")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
