using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_MemberStampStatus")]
public partial class SaveoneGo_MemberStampStatus
{
    [Key]
    public int Id { get; set; }

    [Unicode(false)]
    public string Description { get; set; } = null!;

    public int Status { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    [InverseProperty("StatusNavigation")]
    public virtual ICollection<SaveoneGo_MemberStamp> SaveoneGo_MemberStamps { get; set; } = new List<SaveoneGo_MemberStamp>();
}
