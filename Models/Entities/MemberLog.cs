using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MemberLog")]
public partial class MemberLog
{
    [Key]
    public int Seq { get; set; }

    public long MemberId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Password { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? IdCard { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Mobile { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ShopName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ShopType_1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LicensePlate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("MemberLogs")]
    public virtual Member Member { get; set; } = null!;
}
