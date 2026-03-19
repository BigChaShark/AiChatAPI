using System;
using System.Collections.Generic;

namespace AiChatAPI.Models;

public partial class SaveoneGoMemberRobinson
{
    public long Id { get; set; }

    public int? SaveoneGoZoneMarketId { get; set; }

    public string? Code { get; set; }

    public long? SaveoneGoMemberId { get; set; }

    public long? MemberId { get; set; }

    public string? SellingProduct { get; set; }

    public string? ShopName { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int? ShopType { get; set; }

    public int? RankNo { get; set; }

    public decimal? Score { get; set; }

    public int? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? LastUpdate { get; set; }

    public long? LastUpdateBy { get; set; }
}
