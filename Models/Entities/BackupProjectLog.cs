using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("BackupProjectLog")]
public partial class BackupProjectLog
{
    [Key]
    public int Seq { get; set; }

    public int BackupProjectId { get; set; }

    public DateOnly? ProcessDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsSuccess { get; set; }

    [Column(TypeName = "text")]
    public string? Remark { get; set; }

    [ForeignKey("BackupProjectId")]
    [InverseProperty("BackupProjectLogs")]
    public virtual BackupProject BackupProject { get; set; } = null!;
}
