using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_MemberStamp")]
public partial class SaveoneGo_MemberStamp
{
    [Key]
    public long Id { get; set; }

    public long MemberId { get; set; }

    public int SaveoneGo_ZoneMarketId { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreateDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    public int? isUse { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UseDate { get; set; }

    public int? Score { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CheckDate { get; set; }

    public int? StaffUserId { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    [Unicode(false)]
    public string? TroubleshootingLog { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("SaveoneGo_MemberStamps")]
    public virtual Member Member { get; set; } = null!;

    [InverseProperty("Stamp")]
    public virtual ICollection<SaveoneGo_MemberStamp_GetLog> SaveoneGo_MemberStamp_GetLogs { get; set; } = new List<SaveoneGo_MemberStamp_GetLog>();

    [ForeignKey("SaveoneGo_ZoneMarketId")]
    [InverseProperty("SaveoneGo_MemberStamps")]
    public virtual SaveoneGo_ZoneMarket SaveoneGo_ZoneMarket { get; set; } = null!;

    [ForeignKey("StaffUserId")]
    [InverseProperty("SaveoneGo_MemberStamps")]
    public virtual StaffUser? StaffUser { get; set; }

    [ForeignKey("Status")]
    [InverseProperty("SaveoneGo_MemberStamps")]
    public virtual SaveoneGo_MemberStampStatus? StatusNavigation { get; set; }
}
