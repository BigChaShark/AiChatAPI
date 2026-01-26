using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("TemporaryFoodMenuAddOn")]
public partial class TemporaryFoodMenuAddOn
{
    [Key]
    public long Id { get; set; }

    public long? TemporaryFoodMenuId { get; set; }

    [StringLength(200)]
    public string? Name { get; set; }

    public int? Status { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    public int? MaximumDetail { get; set; }

    public int? MinimumDetail { get; set; }

    [ForeignKey("TemporaryFoodMenuId")]
    [InverseProperty("TemporaryFoodMenuAddOns")]
    public virtual TemporaryFoodMenu? TemporaryFoodMenu { get; set; }

    [InverseProperty("FoodMenuAddOn")]
    public virtual ICollection<TemporaryFoodMenuAddOnDetail> TemporaryFoodMenuAddOnDetails { get; set; } = new List<TemporaryFoodMenuAddOnDetail>();
}
