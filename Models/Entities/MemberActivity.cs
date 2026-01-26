using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MemberActivity")]
public partial class MemberActivity
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

    [StringLength(50)]
    [Unicode(false)]
    public string? Latitude { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Longitude { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("MemberActivities")]
    public virtual Member? Member { get; set; }
}
