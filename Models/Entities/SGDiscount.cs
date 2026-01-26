using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SGDiscount")]
public partial class SGDiscount
{
    [Key]
    public int Id { get; set; }

    public int? SaveoneGo_ZoneMarketId { get; set; }

    public int? LogeGroupId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    public int? LastUpdatBy { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Value { get; set; }

    public int? Status { get; set; }

    [ForeignKey("LogeGroupId")]
    [InverseProperty("SGDiscounts")]
    public virtual LogeGroup? LogeGroup { get; set; }

    [ForeignKey("SaveoneGo_ZoneMarketId")]
    [InverseProperty("SGDiscounts")]
    public virtual SaveoneGo_ZoneMarket? SaveoneGo_ZoneMarket { get; set; }
}
