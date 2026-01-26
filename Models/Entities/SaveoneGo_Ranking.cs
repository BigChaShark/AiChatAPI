using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_Ranking")]
public partial class SaveoneGo_Ranking
{
    [Key]
    public int Id { get; set; }

    public int? SaveoneGo_ZoneMarketId { get; set; }

    [Unicode(false)]
    public string? RankName { get; set; }

    public int? Star { get; set; }

    public int? RankingStart { get; set; }

    public int? RankingEnd { get; set; }

    public TimeOnly? TimeStart { get; set; }

    public TimeOnly? TimeEnd { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }
}
