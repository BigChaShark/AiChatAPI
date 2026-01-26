using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("Absence")]
public partial class Absence
{
    [Key]
    public long Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AbsenceDate { get; set; }

    public long? MemberId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdteDate { get; set; }

    public long? LastUpdateBy { get; set; }

    public int? Status { get; set; }

    [StringLength(200)]
    public string? Reason { get; set; }

    public int? ZoneId { get; set; }

    public long? TransactionId { get; set; }

    [ForeignKey("TransactionId")]
    [InverseProperty("Absences")]
    public virtual Transaction? Transaction { get; set; }
}
