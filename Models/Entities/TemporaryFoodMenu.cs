using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("TemporaryFoodMenu")]
public partial class TemporaryFoodMenu
{
    [Key]
    public long Id { get; set; }

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

    [ForeignKey("FoodShopId")]
    [InverseProperty("TemporaryFoodMenus")]
    public virtual FoodShop? FoodShop { get; set; }

    [InverseProperty("TemporaryFoodMenu")]
    public virtual ICollection<TemporaryFoodMenuAddOn> TemporaryFoodMenuAddOns { get; set; } = new List<TemporaryFoodMenuAddOn>();
}
