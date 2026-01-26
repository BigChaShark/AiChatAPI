using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_CheckScoreTopicList")]
public partial class SaveoneGo_CheckScoreTopicList
{
    [Key]
    public int Id { get; set; }

    public int? TopicId { get; set; }

    [Unicode(false)]
    public string? TopicDetail { get; set; }

    public int? Score { get; set; }

    public int? Status { get; set; }

    public int SaveoneGo_ZoneMarketId { get; set; }

    [InverseProperty("TopicList")]
    public virtual ICollection<SaveoneGo_CheckScoreDetail_Test> SaveoneGo_CheckScoreDetail_Tests { get; set; } = new List<SaveoneGo_CheckScoreDetail_Test>();

    [InverseProperty("TopicList")]
    public virtual ICollection<SaveoneGo_CheckScoreDetail> SaveoneGo_CheckScoreDetails { get; set; } = new List<SaveoneGo_CheckScoreDetail>();

    [ForeignKey("SaveoneGo_ZoneMarketId")]
    [InverseProperty("SaveoneGo_CheckScoreTopicLists")]
    public virtual SaveoneGo_ZoneMarket SaveoneGo_ZoneMarket { get; set; } = null!;

    [ForeignKey("TopicId")]
    [InverseProperty("SaveoneGo_CheckScoreTopicLists")]
    public virtual SaveoneGo_CheckScoreTopic? Topic { get; set; }
}
