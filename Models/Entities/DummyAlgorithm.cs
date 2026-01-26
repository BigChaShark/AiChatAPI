using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("DummyAlgorithm")]
public partial class DummyAlgorithm
{
    [Key]
    public int Seq { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Description { get; set; }

    public int? Amount { get; set; }

    public int? Status { get; set; }

    public int? AppGroup { get; set; }

    public int? SubZoneId { get; set; }

    public int? startTime { get; set; }

    public int? endTime { get; set; }

    public int? Amount2 { get; set; }

    [InverseProperty("DummyAlgorithm")]
    public virtual ICollection<LogicWorkLog> LogicWorkLogs { get; set; } = new List<LogicWorkLog>();

    [ForeignKey("SubZoneId")]
    [InverseProperty("DummyAlgorithms")]
    public virtual SubZone? SubZone { get; set; }
}
