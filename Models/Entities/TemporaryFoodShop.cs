using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("TemporaryFoodShop")]
public partial class TemporaryFoodShop
{
    [Key]
    public long Id { get; set; }

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

    public long? FoodShopId { get; set; }
}
