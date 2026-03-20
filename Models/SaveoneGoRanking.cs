using System;
using System.Collections.Generic;

namespace AiChatAPI.Models;

public partial class SaveoneGoRanking
{
    public int Id { get; set; }

    public int? SaveoneGoZoneMarketId { get; set; }

    public string? RankName { get; set; }

    public int? Star { get; set; }

    public int? RankingStart { get; set; }

    public int? RankingEnd { get; set; }

    public TimeOnly? TimeStart { get; set; }

    public TimeOnly? TimeEnd { get; set; }

    public int? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    public string? Remark { get; set; }
}
