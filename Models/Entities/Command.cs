using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("Command")]
public partial class Command
{
    [Key]
    public long Id { get; set; }

    [Unicode(false)]
    public string? Detail { get; set; }

    [Unicode(false)]
    public string? CommandName { get; set; }

    [Unicode(false)]
    public string? CommandValue { get; set; }

    [Unicode(false)]
    public string? isCommandValueCheck { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? Status { get; set; }

    public int? isActive { get; set; }

    public TimeOnly? Start { get; set; }

    public TimeOnly? End { get; set; }

    public int? setTime { get; set; }
}
