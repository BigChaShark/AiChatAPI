using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SGPromotion_Target")]
public partial class SGPromotion_Target
{
    [Key]
    public long Seq { get; set; }

    public long SGPromotionId { get; set; }

    public int? TargetId { get; set; }

    [ForeignKey("SGPromotionId")]
    [InverseProperty("SGPromotion_Targets")]
    public virtual SGPromotion SGPromotion { get; set; } = null!;

    [ForeignKey("TargetId")]
    [InverseProperty("SGPromotion_Targets")]
    public virtual SaveoneGo_MemberPrivilege? Target { get; set; }
}
