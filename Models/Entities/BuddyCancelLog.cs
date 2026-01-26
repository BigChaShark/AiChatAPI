using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("BuddyCancelLog")]
public partial class BuddyCancelLog
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? Status { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("BuddyCancelLogs")]
    public virtual Member? Member { get; set; }
}
