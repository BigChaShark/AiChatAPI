using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FoodCategory")]
public partial class FoodCategory
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    public string? Name { get; set; }

    public int? Status { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    [StringLength(50)]
    public string? ImageURL { get; set; }

    public int? FoodCategory_UseId { get; set; }

    [InverseProperty("Category")]
    public virtual ICollection<FoodMenuCategory> FoodMenuCategories { get; set; } = new List<FoodMenuCategory>();
}
