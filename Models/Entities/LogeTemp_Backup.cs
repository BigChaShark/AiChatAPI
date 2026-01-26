using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("LogeTemp_Backup")]
public partial class LogeTemp_Backup
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal Seq { get; set; }

    public int LogeId { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string LogeName { get; set; } = null!;

    public DateOnly OpenDateInt { get; set; }

    public int LogeTypeId { get; set; }

    public int LogeIndex { get; set; }

    public int IsConner { get; set; }

    public int Status { get; set; }
}
