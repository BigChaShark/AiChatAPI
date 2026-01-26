using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("ShopId", "DayId")]
[Table("FoodShopOpenDay")]
public partial class FoodShopOpenDay
{
    [Key]
    public long ShopId { get; set; }

    [Key]
    public int DayId { get; set; }

    public int? OpenStatus { get; set; }

    public int? ApproveStatus { get; set; }
}
