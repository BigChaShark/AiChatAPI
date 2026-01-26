using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("LockerMember")]
public partial class LockerMember
{
    [Key]
    public int LockerMemberId { get; set; }

    public int MemberId { get; set; }

    [StringLength(100)]
    public string LogeNo { get; set; } = null!;

    [StringLength(100)]
    public string LockerNo1 { get; set; } = null!;

    [StringLength(100)]
    public string LockerNo2 { get; set; } = null!;

    [StringLength(100)]
    public string LockerNo3 { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreateDate { get; set; }

    public int CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateDate { get; set; }

    public int UpdateBy { get; set; }

    public int Delflag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LockerNo4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LockerNo5 { get; set; }
}
