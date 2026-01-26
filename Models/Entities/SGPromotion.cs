using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SGPromotion")]
public partial class SGPromotion
{
    [Key]
    public long Id { get; set; }

    [Unicode(false)]
    public string? Name { get; set; }

    public int SGPromotionTypeId { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal GoPointValue { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal GoPointMinimum { get; set; }

    public int? TargetTypeId { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    public int? Status { get; set; }

    [ForeignKey("SGPromotionTypeId")]
    [InverseProperty("SGPromotions")]
    public virtual SGPromotionType SGPromotionType { get; set; } = null!;

    [InverseProperty("SGPromotion")]
    public virtual ICollection<SGPromotion_Target> SGPromotion_Targets { get; set; } = new List<SGPromotion_Target>();

    [InverseProperty("SGPromotion")]
    public virtual ICollection<SGPromotion_ZoneMarket> SGPromotion_ZoneMarkets { get; set; } = new List<SGPromotion_ZoneMarket>();

    [ForeignKey("TargetTypeId")]
    [InverseProperty("SGPromotions")]
    public virtual SaveoneGo_MemberPrivilege? TargetType { get; set; }

    [InverseProperty("SGPromotion")]
    public virtual ICollection<TransactionSGPromotion> TransactionSGPromotions { get; set; } = new List<TransactionSGPromotion>();
}
