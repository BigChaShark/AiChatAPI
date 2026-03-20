using System;
using System.Collections.Generic;

namespace AiChatAPI.Models;

public partial class SaveoneGoZoneMarket
{
    public int Id { get; set; }

    public int? SaveoneGoMarketId { get; set; }

    public int ZoneId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int Status { get; set; }

    public DateTime? Vipopen { get; set; }

    public DateTime? Vipclose { get; set; }

    public DateTime? GeneralOpen { get; set; }

    public DateTime? GeneralClose { get; set; }

    public string? CssClass { get; set; }
}
