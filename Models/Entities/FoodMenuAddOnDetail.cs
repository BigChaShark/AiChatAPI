using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FoodMenuAddOnDetail")]
public partial class FoodMenuAddOnDetail
{
    [Key]
    public long Id { get; set; }

    public long? FoodMenuAddOnId { get; set; }

    [StringLength(200)]
    public string? Name { get; set; }

    public int? Status { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? AddPrice { get; set; }

    [ForeignKey("FoodMenuAddOnId")]
    [InverseProperty("FoodMenuAddOnDetails")]
    public virtual FoodMenuAddOn? FoodMenuAddOn { get; set; }
}
