using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("DeliveryDetail")]
public partial class DeliveryDetail
{
    [Key]
    public long Id { get; set; }

    public long? DeliveryId { get; set; }

    public long? SellerId { get; set; }

    public long? ProductId { get; set; }

    public long? ProductModelId { get; set; }

    public int? Qty { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Amount { get; set; }

    public int? Status { get; set; }

    [ForeignKey("DeliveryId")]
    [InverseProperty("DeliveryDetails")]
    public virtual Delivery? Delivery { get; set; }

    [ForeignKey("ProductModelId")]
    [InverseProperty("DeliveryDetails")]
    public virtual ProductModel? ProductModel { get; set; }
}
