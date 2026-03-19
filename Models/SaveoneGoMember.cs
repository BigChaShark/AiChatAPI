using System;
using System.Collections.Generic;

namespace AiChatAPI.Models;

public partial class SaveoneGoMember
{
    public long Id { get; set; }

    public long? MemberId { get; set; }

    public int? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? Ipaddress { get; set; }

    public string? Latitude { get; set; }

    public string? Longitude { get; set; }

    public string? SocialMedia { get; set; }

    public string? SocialMedia2 { get; set; }

    public string? SocialMedia3 { get; set; }

    public string? SellingProduct { get; set; }

    public int? HasBeenOpen { get; set; }

    public int? IsShopStillOpen { get; set; }

    public int? IsFranchise { get; set; }

    public int? RequestLog { get; set; }

    public int? IsNeedStorage { get; set; }

    public string? LineUserId { get; set; }

    public string? LineDisplayName { get; set; }

    public string? LinePictureUrl { get; set; }

    public string? LineStatusMessage { get; set; }

    public int? Accept1 { get; set; }

    public int? Accept2 { get; set; }

    public int? Accept3 { get; set; }

    public string? ShopName { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int? IsFood { get; set; }

    public string? BankCode { get; set; }

    public string? BankName { get; set; }

    public string? BankAccountNo { get; set; }

    public string? BankAccountName { get; set; }

    public int? RankNo { get; set; }

    public decimal? Score { get; set; }

    public decimal? AvgTodayScore { get; set; }

    public long? LastUpdateBy { get; set; }

    public virtual ICollection<SaveoneGoMemberFleaMarket> SaveoneGoMemberFleaMarkets { get; set; } = new List<SaveoneGoMemberFleaMarket>();
}
