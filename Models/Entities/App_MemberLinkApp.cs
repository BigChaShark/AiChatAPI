using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("App_MemberLinkApp")]
public partial class App_MemberLinkApp
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? IPAddress { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Latitude { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Longitude { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DeviceInfo_installationId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DeviceInfo_model { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DeviceInfo_os { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DeviceInfo_platform { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DeviceInfo_timeZone { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? OneSignal_playerId { get; set; }

    public int? Status { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? OneSignal_ExternalID { get; set; }

    [InverseProperty("App_MemberLinkApp")]
    public virtual ICollection<App_MemberLoginLog> App_MemberLoginLogs { get; set; } = new List<App_MemberLoginLog>();

    [ForeignKey("MemberId")]
    [InverseProperty("App_MemberLinkApps")]
    public virtual Member? Member { get; set; }
}
