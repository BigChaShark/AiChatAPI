using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("OpenTimeZone")]
public partial class OpenTimeZone
{
    [Key]
    public int Id { get; set; }

    public int? ZoneId { get; set; }

    public int? ShopTypeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Price { get; set; }

    public int? UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    [ForeignKey("UpdateBy")]
    [InverseProperty("OpenTimeZones")]
    public virtual StaffUser? UpdateByNavigation { get; set; }

    [ForeignKey("ZoneId")]
    [InverseProperty("OpenTimeZones")]
    public virtual Zone? Zone { get; set; }
}
