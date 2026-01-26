using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("ZoneMember")]
public partial class ZoneMember
{
    [Key]
    public int Seq { get; set; }

    public long? MemberId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Page { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Event { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? IPAddress { get; set; }
}
