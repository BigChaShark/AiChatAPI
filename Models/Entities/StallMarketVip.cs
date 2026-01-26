using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("StallMarketVip")]
public partial class StallMarketVip
{
    [Key]
    public long Seq { get; set; }

    public long? MemberId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? LogeQty { get; set; }

    public int? Status { get; set; }
}
