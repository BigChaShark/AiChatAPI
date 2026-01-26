using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("App_MemberLoginLog")]
public partial class App_MemberLoginLog
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

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
    public string? OneSignal_playerId { get; set; }

    public int? Status { get; set; }

    public long? App_MemberLinkAppId { get; set; }

    [ForeignKey("App_MemberLinkAppId")]
    [InverseProperty("App_MemberLoginLogs")]
    public virtual App_MemberLinkApp? App_MemberLinkApp { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("App_MemberLoginLogs")]
    public virtual Member? Member { get; set; }
}
