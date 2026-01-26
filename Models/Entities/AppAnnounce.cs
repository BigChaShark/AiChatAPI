using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("AppAnnounce")]
public partial class AppAnnounce
{
    [Key]
    public long Seq { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Message { get; set; }

    public int? StaffUserId { get; set; }

    [Unicode(false)]
    public string? Url { get; set; }

    [ForeignKey("StaffUserId")]
    [InverseProperty("AppAnnounces")]
    public virtual StaffUser? StaffUser { get; set; }
}
