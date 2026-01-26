using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("CodeGen")]
public partial class CodeGen
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [StringLength(6)]
    public string? Key1 { get; set; }

    [StringLength(50)]
    public string? Key2 { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Amount { get; set; }

    public int? Status { get; set; }

    public long? RequestBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RequestDate { get; set; }

    public long? EnableBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EnableDate { get; set; }

    public long? CancelBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CancelDate { get; set; }

    public long? UserdBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UserdDate { get; set; }
}
