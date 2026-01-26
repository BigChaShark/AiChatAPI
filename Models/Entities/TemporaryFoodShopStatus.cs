using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("TemporaryFoodShopStatus")]
public partial class TemporaryFoodShopStatus
{
    [Key]
    public long Id { get; set; }

    public long? FoodShopId { get; set; }

    public int? Status { get; set; }

    public int? ApproveStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    public long? LastUpdateBy { get; set; }
}
