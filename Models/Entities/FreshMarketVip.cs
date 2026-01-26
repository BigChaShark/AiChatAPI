using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FreshMarketVip")]
public partial class FreshMarketVip
{
    [Key]
    public long Seq { get; set; }

    public long? MemberId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    public int? LogeQty { get; set; }

    public int? Status { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Remark { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("FreshMarketVips")]
    public virtual Member? Member { get; set; }
}
