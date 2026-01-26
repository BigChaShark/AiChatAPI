using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("BackupProject")]
public partial class BackupProject
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? FtpServerPath { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LocalPath { get; set; }

    [StringLength(10)]
    public string? Status { get; set; }

    [InverseProperty("BackupProject")]
    public virtual ICollection<BackupProjectLog> BackupProjectLogs { get; set; } = new List<BackupProjectLog>();
}
