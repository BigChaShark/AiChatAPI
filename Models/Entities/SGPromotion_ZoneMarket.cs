using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SGPromotion_ZoneMarket")]
public partial class SGPromotion_ZoneMarket
{
    [Key]
    public long Seq { get; set; }

    public long SGPromotionId { get; set; }

    public int? SaveoneGo_ZoneMarketId { get; set; }

    [ForeignKey("SGPromotionId")]
    [InverseProperty("SGPromotion_ZoneMarkets")]
    public virtual SGPromotion SGPromotion { get; set; } = null!;

    [ForeignKey("SaveoneGo_ZoneMarketId")]
    [InverseProperty("SGPromotion_ZoneMarkets")]
    public virtual SaveoneGo_ZoneMarket? SaveoneGo_ZoneMarket { get; set; }
}
