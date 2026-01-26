using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Keyless]
[Table("V4$")]
public partial class V4_
{
    public double? Seq { get; set; }

    [StringLength(255)]
    public string? Zone { get; set; }

    [StringLength(255)]
    public string? Nmae { get; set; }

    [StringLength(255)]
    public string? LastName { get; set; }

    [StringLength(255)]
    public string? Mobile { get; set; }

    [StringLength(255)]
    public string? Phone { get; set; }

    [StringLength(255)]
    public string? F7 { get; set; }

    [StringLength(255)]
    public string? F8 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? F9 { get; set; }

    [StringLength(255)]
    public string? Remark { get; set; }
}
