using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("Delivery")]
public partial class Delivery
{
    [Key]
    public long Id { get; set; }

    public long? BuyerId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? AmountToPay { get; set; }

    /// <summary>
    /// 0รอยืนยัน,1ยืนยันสั่งซื้อแล้ว,2รับของแล้ว
    /// </summary>
    public int? Status { get; set; }

    [ForeignKey("BuyerId")]
    [InverseProperty("Deliveries")]
    public virtual Member? Buyer { get; set; }

    [InverseProperty("Delivery")]
    public virtual ICollection<DeliveryDetail> DeliveryDetails { get; set; } = new List<DeliveryDetail>();
}
