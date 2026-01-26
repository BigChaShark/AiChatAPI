using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("BlacklistMemberBooking")]
public partial class BlacklistMemberBooking
{
    [Key]
    public int Seq { get; set; }

    public long MemberId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndDate { get; set; }

    public int BlacklistId { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    public int CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreateDate { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    public int? ZoneId { get; set; }

    [StringLength(100)]
    public string? AttachImage { get; set; }

    public long? RepresentativeId { get; set; }

    public int? isBan { get; set; }

    [ForeignKey("BlacklistId")]
    [InverseProperty("BlacklistMemberBookings")]
    public virtual Blacklist Blacklist { get; set; } = null!;

    [ForeignKey("MemberId")]
    [InverseProperty("BlacklistMemberBookings")]
    public virtual Member Member { get; set; } = null!;

    [InverseProperty("BlacklistMemberBooking")]
    public virtual ICollection<SaveoneGo_Blacklist> SaveoneGo_Blacklists { get; set; } = new List<SaveoneGo_Blacklist>();

    [ForeignKey("ZoneId")]
    [InverseProperty("BlacklistMemberBookings")]
    public virtual Zone? Zone { get; set; }
}
