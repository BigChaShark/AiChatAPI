using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MemberLogeGroup")]
public partial class MemberLogeGroup
{
    [Key]
    public int Seq { get; set; }

    public long MemberId { get; set; }

    public int LogeGroupId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdate { get; set; }

    [ForeignKey("LogeGroupId")]
    [InverseProperty("MemberLogeGroups")]
    public virtual LogeGroup LogeGroup { get; set; } = null!;

    [ForeignKey("MemberId")]
    [InverseProperty("MemberLogeGroups")]
    public virtual Member Member { get; set; } = null!;
}
