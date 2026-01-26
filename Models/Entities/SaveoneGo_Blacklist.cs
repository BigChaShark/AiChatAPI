using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_Blacklist")]
public partial class SaveoneGo_Blacklist
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

    [ForeignKey("BlacklistMemberBookingId")]
    [InverseProperty("SaveoneGo_Blacklists")]
    public virtual BlacklistMemberBooking? BlacklistMemberBooking { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("SaveoneGo_Blacklists")]
    public virtual Member? Member { get; set; }

    [ForeignKey("TransactionId")]
    [InverseProperty("SaveoneGo_Blacklists")]
    public virtual Transaction? Transaction { get; set; }
}
