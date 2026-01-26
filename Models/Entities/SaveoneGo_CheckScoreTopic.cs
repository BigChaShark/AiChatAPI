using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_CheckScoreTopic")]
public partial class SaveoneGo_CheckScoreTopic
{
    [Key]
    public int Id { get; set; }

    public int Seq { get; set; }

    [Unicode(false)]
    public string? Topic { get; set; }

    public int? Status { get; set; }

    public int SaveoneGo_ZoneMarketId { get; set; }

    [InverseProperty("Topic")]
    public virtual ICollection<SaveoneGo_CheckScoreTopicList> SaveoneGo_CheckScoreTopicLists { get; set; } = new List<SaveoneGo_CheckScoreTopicList>();

    [ForeignKey("SaveoneGo_ZoneMarketId")]
    [InverseProperty("SaveoneGo_CheckScoreTopics")]
    public virtual SaveoneGo_ZoneMarket SaveoneGo_ZoneMarket { get; set; } = null!;
}
