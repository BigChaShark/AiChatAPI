using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FreshMarketVipCountErrorLog")]
public partial class FreshMarketVipCountErrorLog
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? IsVipStatusZone2 { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? ErrorMessage { get; set; }
}
