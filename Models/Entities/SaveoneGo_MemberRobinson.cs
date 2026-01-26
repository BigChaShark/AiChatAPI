using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_MemberRobinson")]
public partial class SaveoneGo_MemberRobinson
{
    [Key]
    public long Id { get; set; }

    public int? SaveoneGo_ZoneMarketId { get; set; }

    [Unicode(false)]
    public string? Code { get; set; }

    public long? SaveoneGo_MemberId { get; set; }

    public long? MemberId { get; set; }

    [Unicode(false)]
    public string? SellingProduct { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ShopName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UserName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Password { get; set; }

    public int? ShopType { get; set; }

    public int? RankNo { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Score { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    public long? LastUpdateBy { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("SaveoneGo_MemberRobinsons")]
    public virtual Member? Member { get; set; }
}
