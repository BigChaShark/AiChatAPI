using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_BuddyCancel")]
public partial class SaveoneGo_BuddyCancel
{
    [Key]
    public long Id { get; set; }

    public long? SaveoneGo_BuddyId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateBuddyEnd { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateBuddyEnd_ConfirmDate { get; set; }

    public int? Status_OnConfirmDate { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Notice_ReconnectDate { get; set; }

    public int? Status_AfterNotice { get; set; }

    [ForeignKey("SaveoneGo_BuddyId")]
    [InverseProperty("SaveoneGo_BuddyCancels")]
    public virtual SaveoneGo_Buddy? SaveoneGo_Buddy { get; set; }
}
