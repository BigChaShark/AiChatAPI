using System;
using System.Collections.Generic;

namespace AiChatAPI.Models;

public partial class AllTable
{
    public long Id { get; set; }

    public string TableName { get; set; } = null!;

    public long EnterPriseId { get; set; }

    public DateTime CreateDate { get; set; }
}
