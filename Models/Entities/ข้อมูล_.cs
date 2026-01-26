using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Keyless]
[Table("ข้อมูล$")]
public partial class ข้อมูล_
{
    public double? คอลัมน์1 { get; set; }

    [StringLength(255)]
    public string? คอลัมน์2 { get; set; }

    [StringLength(255)]
    public string? คอลัมน์3 { get; set; }

    [StringLength(255)]
    public string? คอลัมน์32 { get; set; }

    [StringLength(255)]
    public string? Name { get; set; }

    public double? Mobile { get; set; }

    [StringLength(255)]
    public string? Zone { get; set; }

    [StringLength(255)]
    public string? คอลัมน์8 { get; set; }

    [StringLength(255)]
    public string? Status { get; set; }

    [StringLength(255)]
    public string? Dose1 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Dose1Date { get; set; }

    [StringLength(255)]
    public string? Dose2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Dose2Date { get; set; }

    [StringLength(255)]
    public string? BoosterDose { get; set; }

    [StringLength(255)]
    public string? BoosterDoseDate { get; set; }
}
