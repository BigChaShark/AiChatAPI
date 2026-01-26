using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("Line_NotificationLog")]
public partial class Line_NotificationLog
{
    [Key]
    public long Id { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Page { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string SendtoName { get; set; } = null!;

    [Unicode(false)]
    public string? Message { get; set; }

    [Unicode(false)]
    public string? Description { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDate { get; set; }

    public long? UpdateBy { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }
}
