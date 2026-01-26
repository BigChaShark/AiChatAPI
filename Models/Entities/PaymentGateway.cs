using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("PaymentGateway")]
public partial class PaymentGateway
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public int Status { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ImageUrl { get; set; }

    [InverseProperty("PaymentGateway")]
    public virtual ICollection<PaymentGatewayMethod> PaymentGatewayMethods { get; set; } = new List<PaymentGatewayMethod>();

    [InverseProperty("PaymentGateway")]
    public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();

    [InverseProperty("PaymentGateway")]
    public virtual ICollection<Transaction_Backup> Transaction_Backups { get; set; } = new List<Transaction_Backup>();

    [InverseProperty("PaymentGateway")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
