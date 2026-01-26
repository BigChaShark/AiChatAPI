using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class SaveoneGo_MemberSocialMedium
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    public long? SaveoneGO_Memberid { get; set; }

    [StringLength(500)]
    public string? SocialChannel { get; set; }

    [StringLength(500)]
    public string? SocialName { get; set; }

    public int? Status { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("SaveoneGo_MemberSocialMedia")]
    public virtual Member? Member { get; set; }
}
