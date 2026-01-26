using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FoodMenu")]
public partial class FoodMenu
{
    [Key]
    public long Id { get; set; }

    public long? FoodShopId { get; set; }

    [StringLength(100)]
    public string? CategoryName { get; set; }

    [StringLength(200)]
    public string? FoodName { get; set; }

    [StringLength(50)]
    public string? FoodImage { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? FoodPrice { get; set; }

    [StringLength(50)]
    public string? SubKitchen { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    public long? LastUpdateBy { get; set; }

    [StringLength(200)]
    public string? SearchText { get; set; }

    public int? Qty { get; set; }

    [InverseProperty("FoodMenu")]
    public virtual ICollection<FoodMenuAddOn> FoodMenuAddOns { get; set; } = new List<FoodMenuAddOn>();

    [InverseProperty("FoodMenu")]
    public virtual ICollection<FoodMenuCategory> FoodMenuCategories { get; set; } = new List<FoodMenuCategory>();

    [ForeignKey("FoodShopId")]
    [InverseProperty("FoodMenus")]
    public virtual FoodShop? FoodShop { get; set; }

    [InverseProperty("FoodMenu")]
    public virtual ICollection<FoodTransactionDetail> FoodTransactionDetails { get; set; } = new List<FoodTransactionDetail>();
}
