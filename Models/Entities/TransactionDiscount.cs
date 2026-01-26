using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("TransactionDiscount")]
public partial class TransactionDiscount
{
    [Key]
    public long Id { get; set; }

    [Unicode(false)]
    public string? Name { get; set; }

    public long SGPromotionId { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal GoPointValue { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal GoPointMinimum { get; set; }

    public int? DiscountTypeId { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    public int? Status { get; set; }

    [ForeignKey("DiscountTypeId")]
    [InverseProperty("TransactionDiscounts")]
    public virtual DiscountType? DiscountType { get; set; }
}
