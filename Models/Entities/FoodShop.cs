using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FoodShop")]
public partial class FoodShop
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    public long? MemberId { get; set; }

    [StringLength(200)]
    public string? ShopName { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [StringLength(50)]
    public string? ShopImage { get; set; }

    [StringLength(50)]
    public string? DocumentImage1 { get; set; }

    [StringLength(50)]
    public string? DocumentImage2 { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    public long? LastUpdateBy { get; set; }

    public int? ReserveType { get; set; }

    [StringLength(50)]
    public string? TopViewFoodImage { get; set; }

    [StringLength(50)]
    public string? CarWithPlateImage { get; set; }

    [InverseProperty("FoodShop")]
    public virtual ICollection<FoodMenu> FoodMenus { get; set; } = new List<FoodMenu>();

    [ForeignKey("MemberId")]
    [InverseProperty("FoodShops")]
    public virtual Member? Member { get; set; }

    [InverseProperty("FoodShop")]
    public virtual ICollection<TemporaryFoodMenu> TemporaryFoodMenus { get; set; } = new List<TemporaryFoodMenu>();
}
