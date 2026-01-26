using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("FoodMenuId", "CategoryId")]
[Table("FoodMenuCategory")]
public partial class FoodMenuCategory
{
    [Key]
    public long FoodMenuId { get; set; }

    [Key]
    public int CategoryId { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("FoodMenuCategories")]
    public virtual FoodCategory Category { get; set; } = null!;

    [ForeignKey("FoodMenuId")]
    [InverseProperty("FoodMenuCategories")]
    public virtual FoodMenu FoodMenu { get; set; } = null!;
}
