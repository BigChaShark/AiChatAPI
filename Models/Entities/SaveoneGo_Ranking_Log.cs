using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_Ranking_Log")]
public partial class SaveoneGo_Ranking_Log
{
    [Key]
    public long Id { get; set; }

    public int? SaveoneGo_ZoneMarketId { get; set; }

    public int? Star { get; set; }

    public int? RankingStart { get; set; }

    public int? RankingEnd { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }
}
