using System;
using System.Collections.Generic;

namespace AiChatAPI.Models;

public partial class ChatLog
{
    public long Seq { get; set; }

    public long EnterPriseId { get; set; }

    public string UserId { get; set; } = null!;

    public string? Q { get; set; }

    public string? A { get; set; }

    public DateTime TimeStamp { get; set; }
}
