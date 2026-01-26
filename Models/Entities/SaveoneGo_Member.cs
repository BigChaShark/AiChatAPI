using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_Member")]
public partial class SaveoneGo_Member
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? IPAddress { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Latitude { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Longitude { get; set; }

    [Unicode(false)]
    public string? SocialMedia { get; set; }

    [Unicode(false)]
    public string? SocialMedia2 { get; set; }

    [Unicode(false)]
    public string? SocialMedia3 { get; set; }

    [Unicode(false)]
    public string? SellingProduct { get; set; }

    public int? hasBeenOpen { get; set; }

    public int? isShopStillOpen { get; set; }

    public int? isFranchise { get; set; }

    public int? RequestLog { get; set; }

    public int? isNeedStorage { get; set; }

    [Unicode(false)]
    public string? Line_userId { get; set; }

    [Unicode(false)]
    public string? Line_displayName { get; set; }

    [Unicode(false)]
    public string? Line_pictureUrl { get; set; }

    [Unicode(false)]
    public string? Line_statusMessage { get; set; }

    public int? Accept1 { get; set; }

    public int? Accept2 { get; set; }

    public int? Accept3 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ShopName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UserName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Password { get; set; }

    public int? IsFood { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BankCode { get; set; }

    [Unicode(false)]
    public string? BankName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? BankAccountNo { get; set; }

    [Unicode(false)]
    public string? BankAccountName { get; set; }

    public int? RankNo { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Score { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Avg_todayScore { get; set; }

    public long? LastUpdateBy { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("SaveoneGo_Members")]
    public virtual Member? Member { get; set; }

    [InverseProperty("SaveoneGoMember")]
    public virtual ICollection<SaveonGO_TransactionGetLogeNoPaid> SaveonGO_TransactionGetLogeNoPaids { get; set; } = new List<SaveonGO_TransactionGetLogeNoPaid>();

    [InverseProperty("SaveoneGo_Member")]
    public virtual ICollection<SaveoneGo_MemberImage> SaveoneGo_MemberImages { get; set; } = new List<SaveoneGo_MemberImage>();

    [InverseProperty("SaveoneGo_Member")]
    public virtual ICollection<SaveoneGo_Member_FleaMarket> SaveoneGo_Member_FleaMarkets { get; set; } = new List<SaveoneGo_Member_FleaMarket>();

    [InverseProperty("SaveoneGoMember")]
    public virtual ICollection<saveonGO_TransactionReturn> saveonGO_TransactionReturns { get; set; } = new List<saveonGO_TransactionReturn>();
}
