using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class LogeEditForm
{
    [Key]
    public long Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? MemberId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? OldLoge { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NewLoge { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Remark { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? WaterMeter { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ElectricMeter { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MeterDate { get; set; }

    [StringLength(10)]
    public string? Remark2 { get; set; }

    public int? UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("LogeEditForms")]
    public virtual Member? Member { get; set; }
}
