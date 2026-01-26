using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FoodMenuFlashSale")]
public partial class FoodMenuFlashSale
{
    [Key]
    public long FoodMenuId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SaleDate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? SalePrice { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? Status { get; set; }

    public int? Qty { get; set; }
}
