using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_Whitelist")]
public partial class SaveoneGo_Whitelist
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    public int? ZoneId { get; set; }

    public int? SubZoneId { get; set; }

    public int? isActive { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndDate { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("SaveoneGo_Whitelists")]
    public virtual Member? Member { get; set; }
}
