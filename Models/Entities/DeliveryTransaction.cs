using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("DeliveryTransaction")]
public partial class DeliveryTransaction
{
    [Key]
    public long Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? DeliveryTransactionStatusId { get; set; }

    public long? CustomerId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CustomerName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CustomerMobile { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Address { get; set; }

    public long? FoodSenderId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SenderName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SenderMobileNo { get; set; }

    public int? PaymentTypeId { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? TotalAmount { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Latitude { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Longtitude { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("DeliveryTransactions")]
    public virtual Customer? Customer { get; set; }

    [InverseProperty("DeliveryTransaction")]
    public virtual ICollection<DeliveryTransactionDetail> DeliveryTransactionDetails { get; set; } = new List<DeliveryTransactionDetail>();

    [ForeignKey("DeliveryTransactionStatusId")]
    [InverseProperty("DeliveryTransactions")]
    public virtual DeliveryTransactionStatus? DeliveryTransactionStatus { get; set; }

    [ForeignKey("FoodSenderId")]
    [InverseProperty("DeliveryTransactions")]
    public virtual FoodSender? FoodSender { get; set; }

    [InverseProperty("DeliveryTransaction")]
    public virtual ICollection<KitchenWalletLog> KitchenWalletLogs { get; set; } = new List<KitchenWalletLog>();

    [ForeignKey("PaymentTypeId")]
    [InverseProperty("DeliveryTransactions")]
    public virtual PaymentType? PaymentType { get; set; }
}
