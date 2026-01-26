using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("LineApiLog")]
public partial class LineApiLog
{
    [Key]
    public long Seq { get; set; }

    public int LineApiTypeId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LineId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? InputMsg { get; set; }

    [Column(TypeName = "text")]
    public string? RespMsg { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TimeStamp { get; set; }

    [ForeignKey("LineApiTypeId")]
    [InverseProperty("LineApiLogs")]
    public virtual LineApiType LineApiType { get; set; } = null!;
}
