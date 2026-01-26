using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("TransactionSGPromotion")]
public partial class TransactionSGPromotion
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

    public int? TargetTypeId { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    public int? Status { get; set; }

    [ForeignKey("SGPromotionId")]
    [InverseProperty("TransactionSGPromotions")]
    public virtual SGPromotion SGPromotion { get; set; } = null!;
}
