using System;
using System.Collections.Generic;

namespace AiChatAPI.Models;

public partial class ServiceDetailZuesM
{
    public long ServiceId { get; set; }

    public string? ServiceName { get; set; }

    public decimal Price { get; set; }

    public long Status { get; set; }

    public DateTime CreateDate { get; set; }
}
