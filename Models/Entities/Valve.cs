using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("Valve")]
public partial class Valve
{
    [Key]
    public int Id { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "decimal(5, 1)")]
    public decimal? UseMinute { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UseStartDate { get; set; }

    public long? LastOnBy { get; set; }
}
