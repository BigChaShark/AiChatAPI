using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FreshMarketVipStatusLog")]
public partial class FreshMarketVipStatusLog
{
    [Key]
    public long Seq { get; set; }

    public long? MemberId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    public int? Status { get; set; }

    public int? Status2 { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("FreshMarketVipStatusLogs")]
    public virtual Member? Member { get; set; }
}
