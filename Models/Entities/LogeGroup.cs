using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("LogeGroup")]
public partial class LogeGroup
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Unicode(false)]
    public string? Description { get; set; }

    public int GroupSeqNo { get; set; }

    public int ZoneId { get; set; }

    public int Status { get; set; }

    public int UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdate { get; set; }

    public int? SubZoneId { get; set; }

    [InverseProperty("LogeGroup")]
    public virtual LogeGroupOpenDate? LogeGroupOpenDate { get; set; }

    [InverseProperty("LogeGroup")]
    public virtual ICollection<Loge> Loges { get; set; } = new List<Loge>();

    [InverseProperty("LogeGroup")]
    public virtual ICollection<MemberLogeGroup> MemberLogeGroups { get; set; } = new List<MemberLogeGroup>();

    [InverseProperty("LogeGroup")]
    public virtual ICollection<SGDiscount> SGDiscounts { get; set; } = new List<SGDiscount>();

    [ForeignKey("SubZoneId")]
    [InverseProperty("LogeGroups")]
    public virtual SubZone? SubZone { get; set; }

    [ForeignKey("UpdateBy")]
    [InverseProperty("LogeGroups")]
    public virtual StaffUser UpdateByNavigation { get; set; } = null!;

    [ForeignKey("ZoneId")]
    [InverseProperty("LogeGroups")]
    public virtual Zone Zone { get; set; } = null!;
}
