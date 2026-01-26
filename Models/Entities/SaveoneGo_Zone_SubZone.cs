using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("SubZoneId", "ZoneId")]
[Table("SaveoneGo_Zone_SubZone")]
public partial class SaveoneGo_Zone_SubZone
{
    [Key]
    public int ZoneId { get; set; }

    [Key]
    public int SubZoneId { get; set; }

    public int SaveoneGo_ZoneMarketId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Unicode(false)]
    public string? Description { get; set; }

    public int Status { get; set; }

    [ForeignKey("SaveoneGo_ZoneMarketId")]
    [InverseProperty("SaveoneGo_Zone_SubZones")]
    public virtual SaveoneGo_ZoneMarket SaveoneGo_ZoneMarket { get; set; } = null!;

    [ForeignKey("SubZoneId")]
    [InverseProperty("SaveoneGo_Zone_SubZones")]
    public virtual SubZone SubZone { get; set; } = null!;

    [ForeignKey("ZoneId")]
    [InverseProperty("SaveoneGo_Zone_SubZones")]
    public virtual Zone Zone { get; set; } = null!;
}
