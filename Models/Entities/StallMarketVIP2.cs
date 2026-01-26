using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("StallMarketVIP2")]
public partial class StallMarketVIP2
{
    [Key]
    public long Id { get; set; }

    public long MemberId { get; set; }

    public int? VIPGroup { get; set; }
}
