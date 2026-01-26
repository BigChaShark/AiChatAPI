using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_MemberStamp_GetLog")]
public partial class SaveoneGo_MemberStamp_GetLog
{
    [Key]
    public long Id { get; set; }

    public long MemberId { get; set; }

    public int SaveoneGo_ZoneMarketId { get; set; }

    public long? TranId { get; set; }

    public int? CountDate { get; set; }

    [Unicode(false)]
    public string? TroubleshootingLog { get; set; }

    public int? isComplete { get; set; }

    public long? StampId { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("SaveoneGo_MemberStamp_GetLogs")]
    public virtual Member Member { get; set; } = null!;

    [ForeignKey("SaveoneGo_ZoneMarketId")]
    [InverseProperty("SaveoneGo_MemberStamp_GetLogs")]
    public virtual SaveoneGo_ZoneMarket SaveoneGo_ZoneMarket { get; set; } = null!;

    [ForeignKey("StampId")]
    [InverseProperty("SaveoneGo_MemberStamp_GetLogs")]
    public virtual SaveoneGo_MemberStamp? Stamp { get; set; }
}
