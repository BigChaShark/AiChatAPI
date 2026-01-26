using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("AutoRefundLog")]
public partial class AutoRefundLog
{
    [Key]
    public int Seq { get; set; }

    public DateOnly ProcessDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndTime { get; set; }

    public int AllQty { get; set; }

    public int SuccessQty { get; set; }

    [Unicode(false)]
    public string? FailDescription { get; set; }

    public int? SubZoneId { get; set; }
}
