using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_Buddy")]
public partial class SaveoneGo_Buddy
{
    [Key]
    public long Id { get; set; }

    public long? MemberId_Host { get; set; }

    public long? MemberId_Buddy { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateBuddyEnd { get; set; }

    public int? isBan { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndBanDate { get; set; }

    public long? UpdateBy { get; set; }

    public long? BanBy { get; set; }

    [ForeignKey("MemberId_Buddy")]
    [InverseProperty("SaveoneGo_BuddyMemberId_BuddyNavigations")]
    public virtual Member? MemberId_BuddyNavigation { get; set; }

    [ForeignKey("MemberId_Host")]
    [InverseProperty("SaveoneGo_BuddyMemberId_HostNavigations")]
    public virtual Member? MemberId_HostNavigation { get; set; }

    [InverseProperty("SaveoneGo_Buddy")]
    public virtual ICollection<SaveoneGo_BuddyCancel> SaveoneGo_BuddyCancels { get; set; } = new List<SaveoneGo_BuddyCancel>();
}
