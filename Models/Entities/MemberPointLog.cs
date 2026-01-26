using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MemberPointLog")]
public partial class MemberPointLog
{
    [Key]
    public long Seq { get; set; }

    public long MemberId { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal Amount { get; set; }

    public int MemberPointLogTypeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdate { get; set; }

    [Column(TypeName = "numeric(9, 0)")]
    public decimal? AmountBalance { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? StaffUserId { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("MemberPointLogs")]
    public virtual Member Member { get; set; } = null!;

    [ForeignKey("MemberPointLogTypeId")]
    [InverseProperty("MemberPointLogs")]
    public virtual MemberPointLogType MemberPointLogType { get; set; } = null!;

    [ForeignKey("StaffUserId")]
    [InverseProperty("MemberPointLogs")]
    public virtual StaffUser? StaffUser { get; set; }
}
