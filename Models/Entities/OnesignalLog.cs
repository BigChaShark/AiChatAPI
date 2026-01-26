using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("OnesignalLog")]
public partial class OnesignalLog
{
    [Key]
    public long Seq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Notify { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? Status { get; set; }
}
