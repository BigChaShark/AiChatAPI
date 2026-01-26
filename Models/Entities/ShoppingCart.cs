using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("ShoppingCart")]
public partial class ShoppingCart
{
    [Key]
    public long Id { get; set; }

    public int? ShoppingCartStatusId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CustomerId { get; set; }

    public int? PaymentGatewayId { get; set; }

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

    [ForeignKey("PaymentGatewayId")]
    [InverseProperty("ShoppingCarts")]
    public virtual PaymentGateway? PaymentGateway { get; set; }

    [InverseProperty("ShoppingCart")]
    public virtual ICollection<ShoppingCartDetail> ShoppingCartDetails { get; set; } = new List<ShoppingCartDetail>();

    [ForeignKey("ShoppingCartStatusId")]
    [InverseProperty("ShoppingCarts")]
    public virtual ShoppingCartStatus? ShoppingCartStatus { get; set; }
}
