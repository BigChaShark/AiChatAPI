using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_ZoneMarket")]
public partial class SaveoneGo_ZoneMarket
{
    [Key]
    public int Id { get; set; }

    public int? SaveoneGo_MarketId { get; set; }

    public int ZoneId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Code { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Unicode(false)]
    public string? Description { get; set; }

    public int Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VIPOpen { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VIPClose { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GeneralOpen { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GeneralClose { get; set; }

    [InverseProperty("SaveoneGo_ZoneMarket")]
    public virtual ICollection<SGDiscount> SGDiscounts { get; set; } = new List<SGDiscount>();

    [InverseProperty("SaveoneGo_ZoneMarket")]
    public virtual ICollection<SGPromotion_ZoneMarket> SGPromotion_ZoneMarkets { get; set; } = new List<SGPromotion_ZoneMarket>();

    [InverseProperty("SaveoneGo_ZoneMarket")]
    public virtual ICollection<SaveoneGo_CheckScoreDetail_Test> SaveoneGo_CheckScoreDetail_Tests { get; set; } = new List<SaveoneGo_CheckScoreDetail_Test>();

    [InverseProperty("SaveoneGo_ZoneMarket")]
    public virtual ICollection<SaveoneGo_CheckScoreDetail> SaveoneGo_CheckScoreDetails { get; set; } = new List<SaveoneGo_CheckScoreDetail>();

    [InverseProperty("SaveoneGo_ZoneMarket")]
    public virtual ICollection<SaveoneGo_CheckScoreTopicList> SaveoneGo_CheckScoreTopicLists { get; set; } = new List<SaveoneGo_CheckScoreTopicList>();

    [InverseProperty("SaveoneGo_ZoneMarket")]
    public virtual ICollection<SaveoneGo_CheckScoreTopic> SaveoneGo_CheckScoreTopics { get; set; } = new List<SaveoneGo_CheckScoreTopic>();

    [InverseProperty("SaveoneGo_ZoneMarket")]
    public virtual ICollection<SaveoneGo_CheckScore_Test> SaveoneGo_CheckScore_Tests { get; set; } = new List<SaveoneGo_CheckScore_Test>();

    [InverseProperty("SaveoneGo_ZoneMarket")]
    public virtual ICollection<SaveoneGo_CheckScore> SaveoneGo_CheckScores { get; set; } = new List<SaveoneGo_CheckScore>();

    [ForeignKey("SaveoneGo_MarketId")]
    [InverseProperty("SaveoneGo_ZoneMarkets")]
    public virtual SaveoneGo_Market? SaveoneGo_Market { get; set; }

    [InverseProperty("SaveoneGo_ZoneMarket")]
    public virtual ICollection<SaveoneGo_MemberStamp_GetLog> SaveoneGo_MemberStamp_GetLogs { get; set; } = new List<SaveoneGo_MemberStamp_GetLog>();

    [InverseProperty("SaveoneGo_ZoneMarket")]
    public virtual ICollection<SaveoneGo_MemberStamp> SaveoneGo_MemberStamps { get; set; } = new List<SaveoneGo_MemberStamp>();

    [InverseProperty("SaveoneGo_ZoneMarket")]
    public virtual ICollection<SaveoneGo_Queue> SaveoneGo_Queues { get; set; } = new List<SaveoneGo_Queue>();

    [InverseProperty("SaveoneGo_ZoneMarket")]
    public virtual ICollection<SaveoneGo_Zone_SubZone> SaveoneGo_Zone_SubZones { get; set; } = new List<SaveoneGo_Zone_SubZone>();

    [ForeignKey("ZoneId")]
    [InverseProperty("SaveoneGo_ZoneMarkets")]
    public virtual Zone Zone { get; set; } = null!;
}
