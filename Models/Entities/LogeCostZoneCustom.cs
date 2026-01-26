using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("LogeCostZoneCustom")]
public partial class LogeCostZoneCustom
{
    [Key]
    public long Id { get; set; }

    public int? LogeId { get; set; }

    public long? MemberId { get; set; }

    public int? SubZoneId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Day { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Cost { get; set; }

    public int? UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }
}
