using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MemberVip")]
public partial class MemberVip
{
    [Key]
    public int Seq { get; set; }

    public long? MemberId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? LogeQty { get; set; }

    public int? ZoneId { get; set; }

    public int? Status { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Remark { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("MemberVips")]
    public virtual Member? Member { get; set; }

    [ForeignKey("ZoneId")]
    [InverseProperty("MemberVips")]
    public virtual Zone? Zone { get; set; }
}
