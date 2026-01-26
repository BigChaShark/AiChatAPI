using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("BuyerId", "SellerId")]
[Table("FavouriteShop")]
public partial class FavouriteShop
{
    [Key]
    public long BuyerId { get; set; }

    [Key]
    public long SellerId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }
}
