using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("Blacklist")]
public partial class Blacklist
{
    [Key]
    public int Id { get; set; }

    [Unicode(false)]
    public string Description { get; set; } = null!;

    public int Status { get; set; }

    [InverseProperty("Blacklist")]
    public virtual ICollection<BlacklistMemberBooking> BlacklistMemberBookings { get; set; } = new List<BlacklistMemberBooking>();

    [InverseProperty("Blacklist")]
    public virtual ICollection<BlacklistMember> BlacklistMembers { get; set; } = new List<BlacklistMember>();
}
