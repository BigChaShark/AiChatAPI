using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class SaveoneGo_Buddy_Log
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
    public DateTime? DateBuddyEnd { get; set; }

    public int? isBan { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndBanDate { get; set; }

    public long? UpdateBy { get; set; }

    public long? BanBy { get; set; }

    public int? IsBuddy { get; set; }

    [StringLength(50)]
    public string? Remark { get; set; }
}
