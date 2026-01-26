using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_CheckScoreSpecial_Backup")]
public partial class SaveoneGo_CheckScoreSpecial_Backup
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    [Column(TypeName = "decimal(2, 0)")]
    public decimal? SpecialScore1 { get; set; }

    [Column(TypeName = "decimal(2, 0)")]
    public decimal? SpecialScore2 { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    public long? TransactionId { get; set; }

    public int? SaveoneGo_ZoneMarketId { get; set; }
}
