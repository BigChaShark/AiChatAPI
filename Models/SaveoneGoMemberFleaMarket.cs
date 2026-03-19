using System;
using System.Collections.Generic;

namespace AiChatAPI.Models;

public partial class SaveoneGoMemberFleaMarket
{
    public long Id { get; set; }

    public long? SaveoneGoMemberId { get; set; }

    public long? MemberId { get; set; }

    public int? RankNo { get; set; }

    public decimal? Score { get; set; }

    public int? FleaMarketShopTypeId { get; set; }

    public string? ShopName { get; set; }

    public string? SellingProduct { get; set; }

    public int? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? LastUpdate { get; set; }

    public int? SubZoneId { get; set; }

    public int? ZoneId { get; set; }

    public long? LastUpdateBy { get; set; }

    public virtual SaveoneGoFleaMarketShopType? FleaMarketShopType { get; set; }

    public virtual SaveoneGoMember? SaveoneGoMember { get; set; }
}
