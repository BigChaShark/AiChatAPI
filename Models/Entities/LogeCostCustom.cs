using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("LogeCostCustom")]
public partial class LogeCostCustom
{
    [Key]
    public int Id { get; set; }

    public long? MemberId { get; set; }

    public int? ZoneId { get; set; }

    public int? SubZoneId { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Cost { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    public int? UpdateBy { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("LogeCostCustoms")]
    public virtual Member? Member { get; set; }

    [ForeignKey("SubZoneId")]
    [InverseProperty("LogeCostCustoms")]
    public virtual SubZone? SubZone { get; set; }

    [ForeignKey("ZoneId")]
    [InverseProperty("LogeCostCustoms")]
    public virtual Zone? Zone { get; set; }
}
