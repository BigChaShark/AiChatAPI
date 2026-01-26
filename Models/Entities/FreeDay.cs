using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("Date", "ZoneId")]
public partial class FreeDay
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    [Key]
    public int ZoneId { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [ForeignKey("ZoneId")]
    [InverseProperty("FreeDays")]
    public virtual Zone Zone { get; set; } = null!;
}
