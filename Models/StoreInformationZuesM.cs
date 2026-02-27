using System;
using System.Collections.Generic;

namespace AiChatAPI.Models;

public partial class StoreInformationZuesM
{
    public long Seq { get; set; }

    public long Branch { get; set; }

    public string? BranchName { get; set; }

    public string LocationId { get; set; } = null!;

    public string? LocationDetail { get; set; }

    public TimeOnly OpenTime { get; set; }

    public TimeOnly CloseTime { get; set; }

    public long Status { get; set; }

    public DateTime CreateDate { get; set; }
}
