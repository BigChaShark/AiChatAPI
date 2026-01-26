using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("MemberId", "SubZoneId")]
public partial class MemberStatisticRanking
{
    [Key]
    public long MemberId { get; set; }

    [Key]
    public int SubZoneId { get; set; }

    public int SubZoneRanking { get; set; }

    public int? SubZoneCount { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? MaxAmount { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Amount1 { get; set; }

    public int? CountAmount1 { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Amount2 { get; set; }

    public int? CountAmount2 { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Amount3 { get; set; }

    public int? CountAmount3 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? Status { get; set; }
}
