using System;
using System.Collections.Generic;

namespace AiChatAPI.Models;

public partial class Sgsaving
{
    public long Seq { get; set; }

    public long MemberId { get; set; }

    public decimal? BalanceAmount { get; set; }
}
