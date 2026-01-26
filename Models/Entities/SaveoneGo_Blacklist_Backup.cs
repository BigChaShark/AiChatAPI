using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_Blacklist_Backup")]
public partial class SaveoneGo_Blacklist_Backup
{
    [Key]
    public long Id { get; set; }

    public int? BlacklistMemberBookingId { get; set; }

    public long? BlacklistTypeId { get; set; }

    public long? MemberId { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    public long? TransactionId { get; set; }
}
