using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("Onesignal_PushNotification")]
public partial class Onesignal_PushNotification
{
    [Key]
    public long Seq { get; set; }

    public int? isSendAll { get; set; }

    public long? MemberId { get; set; }

    public long? App_MemberLinkAppId { get; set; }

    [Unicode(false)]
    public string? Topic { get; set; }

    [Unicode(false)]
    public string? Message { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? Status { get; set; }

    [Unicode(false)]
    public string? ErrorMessage { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("Onesignal_PushNotifications")]
    public virtual Member? Member { get; set; }
}
