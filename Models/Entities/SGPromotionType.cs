using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SGPromotionType")]
public partial class SGPromotionType
{
    [Key]
    public int Id { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? GoPointType { get; set; }

    public int Status { get; set; }

    [InverseProperty("SGPromotionType")]
    public virtual ICollection<SGPromotion> SGPromotions { get; set; } = new List<SGPromotion>();
}
