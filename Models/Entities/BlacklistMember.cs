using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("BlacklistMember")]
public partial class BlacklistMember
{
    [Key]
    public int Seq { get; set; }

    public long MemberId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndDate { get; set; }

    public int BlacklistId { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    public int CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreateDate { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    /// <summary>
    /// 1 = ตักเตือน , 2 = ลา
    /// </summary>
    public int? IsAdmonish { get; set; }

    public int? ZoneId { get; set; }

    [StringLength(100)]
    public string? AttachImage { get; set; }

    public long? RepresentativeId { get; set; }

    [ForeignKey("BlacklistId")]
    [InverseProperty("BlacklistMembers")]
    public virtual Blacklist Blacklist { get; set; } = null!;

    [ForeignKey("MemberId")]
    [InverseProperty("BlacklistMembers")]
    public virtual Member Member { get; set; } = null!;

    [ForeignKey("ZoneId")]
    [InverseProperty("BlacklistMembers")]
    public virtual Zone? Zone { get; set; }
}
