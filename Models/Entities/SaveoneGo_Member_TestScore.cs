using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_Member_TestScore")]
public partial class SaveoneGo_Member_TestScore
{
    [Key]
    public long Id { get; set; }

    public long? SaveoneGo_MemberId { get; set; }

    public long? MemberId { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? RankNo { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Score { get; set; }

    public int? SaveoneGo_ZoneMarketId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LogDateTime { get; set; }

    public int? CalculateDate { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("SaveoneGo_Member_TestScores")]
    public virtual Member? Member { get; set; }
}
