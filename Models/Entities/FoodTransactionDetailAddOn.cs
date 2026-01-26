using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FoodTransactionDetailAddOn")]
public partial class FoodTransactionDetailAddOn
{
    [Key]
    public long Id { get; set; }

    public long? FoodTransactionDetailId { get; set; }

    public long? AddOnId { get; set; }

    [StringLength(200)]
    public string? AddOnName { get; set; }

    public long? AddOnDetailId { get; set; }

    [StringLength(200)]
    public string? AddOnDetailName { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? AddPrice { get; set; }

    [ForeignKey("FoodTransactionDetailId")]
    [InverseProperty("FoodTransactionDetailAddOns")]
    public virtual FoodTransactionDetail? FoodTransactionDetail { get; set; }
}
