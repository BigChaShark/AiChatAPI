using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("LineApiType")]
public partial class LineApiType
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Description { get; set; }

    public int Status { get; set; }

    [InverseProperty("LineApiType")]
    public virtual ICollection<LineApiLog> LineApiLogs { get; set; } = new List<LineApiLog>();
}
