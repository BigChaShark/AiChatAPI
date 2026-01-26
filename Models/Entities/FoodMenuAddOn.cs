using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FoodMenuAddOn")]
public partial class FoodMenuAddOn
{
    [Key]
    public long Id { get; set; }

    public long? FoodMenuId { get; set; }

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

    [ForeignKey("FoodMenuId")]
    [InverseProperty("FoodMenuAddOns")]
    public virtual FoodMenu? FoodMenu { get; set; }

    [InverseProperty("FoodMenuAddOn")]
    public virtual ICollection<FoodMenuAddOnDetail> FoodMenuAddOnDetails { get; set; } = new List<FoodMenuAddOnDetail>();
}
