using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_Market")]
public partial class SaveoneGo_Market
{
    [Key]
    public int Id { get; set; }

    public int ZoneId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Code { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Unicode(false)]
    public string? Description { get; set; }

    public int Status { get; set; }

    [Unicode(false)]
    public string? ImagePlace { get; set; }

    [Column(TypeName = "decimal(9, 6)")]
    public decimal? Latitude { get; set; }

    [Column(TypeName = "decimal(9, 6)")]
    public decimal? Longitude { get; set; }

    [InverseProperty("SaveoneGo_Market")]
    public virtual ICollection<SaveoneGo_ZoneMarket> SaveoneGo_ZoneMarkets { get; set; } = new List<SaveoneGo_ZoneMarket>();

    [ForeignKey("ZoneId")]
    [InverseProperty("SaveoneGo_Markets")]
    public virtual Zone Zone { get; set; } = null!;
}
