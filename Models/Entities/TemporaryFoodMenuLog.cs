using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("TemporaryFoodMenuLog")]
public partial class TemporaryFoodMenuLog
{
    [Key]
    public long Id { get; set; }

    public long? TemporaryFoodMenuId { get; set; }

    public long? FoodShopId { get; set; }

    public long? FoodMenuId { get; set; }

    [StringLength(200)]
    public string? FoodName { get; set; }

    [StringLength(50)]
    public string? FoodImage { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? FoodPrice { get; set; }

    public int? Status { get; set; }

    public int? ApproveStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    public long? LastUpdateBy { get; set; }

    [StringLength(200)]
    public string? SearchText { get; set; }

    [StringLength(200)]
    public string? Category { get; set; }
}
