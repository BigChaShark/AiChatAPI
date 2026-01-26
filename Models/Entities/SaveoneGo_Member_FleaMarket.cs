using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_Member_FleaMarket")]
public partial class SaveoneGo_Member_FleaMarket
{
    [Key]
    public long Id { get; set; }

    public long? SaveoneGo_MemberId { get; set; }

    public long? MemberId { get; set; }

    public int? RankNo { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Score { get; set; }

    public int? FleaMarketShopTypeId { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ShopName { get; set; }

    [Unicode(false)]
    public string? SellingProduct { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    public int? SubZoneId { get; set; }

    public int? ZoneId { get; set; }

    public long? LastUpdateBy { get; set; }

    [ForeignKey("FleaMarketShopTypeId")]
    [InverseProperty("SaveoneGo_Member_FleaMarkets")]
    public virtual SaveoneGo_FleaMarketShopType? FleaMarketShopType { get; set; }

    [ForeignKey("SaveoneGo_MemberId")]
    [InverseProperty("SaveoneGo_Member_FleaMarkets")]
    public virtual SaveoneGo_Member? SaveoneGo_Member { get; set; }
}
