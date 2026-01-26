using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("Buddy")]
public partial class Buddy
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    public long? BuddyId { get; set; }

    public long? BuddyId2 { get; set; }

    public long? BuddyId3 { get; set; }

    public long? BuddyId4 { get; set; }

    public long? BuddyId5 { get; set; }

    public int? Status { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("Buddies")]
    public virtual Member? Member { get; set; }
}
