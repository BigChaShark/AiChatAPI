using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_MemberScore_Freeze")]
public partial class SaveoneGo_MemberScore_Freeze
{
    [Key]
    public long Id { get; set; }

    public int? SaveoneGo_ZoneMarketId { get; set; }

    public long? MemberId { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? LastScore { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDateofBreak { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDateofBreak { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    public int CreateBy { get; set; }

    [Column("EffectiveDate _Start", TypeName = "datetime")]
    public DateTime? EffectiveDate__Start { get; set; }

    [Column("EffectiveDate _End", TypeName = "datetime")]
    public DateTime? EffectiveDate__End { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CalculateDate { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("SaveoneGo_MemberScore_Freezes")]
    public virtual Member? Member { get; set; }
}
