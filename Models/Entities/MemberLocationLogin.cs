using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MemberLocationLogin")]
public partial class MemberLocationLogin
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    [StringLength(100)]
    public string? RefKey { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LogDate { get; set; }

    [Column(TypeName = "decimal(11, 8)")]
    public decimal? Latitude { get; set; }

    [Column(TypeName = "decimal(11, 8)")]
    public decimal? Longitude { get; set; }
}
