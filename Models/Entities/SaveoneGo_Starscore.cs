using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_Starscore")]
public partial class SaveoneGo_Starscore
{
    [Key]
    public long Id { get; set; }

    public int? ZoneMarketId { get; set; }

    public long? MemberId { get; set; }

    public long? Saveone_MemberId { get; set; }

    [StringLength(50)]
    public string? ShopId { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? StarScore { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }
}
