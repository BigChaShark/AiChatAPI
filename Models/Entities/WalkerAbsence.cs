using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("WalkerAbsence")]
public partial class WalkerAbsence
{
    [Key]
    public long Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AbsenceDate { get; set; }

    public long? WalkerId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdteDate { get; set; }

    public long? LastUpdateBy { get; set; }

    public int? Status { get; set; }

    [StringLength(200)]
    public string? Reason { get; set; }
}
