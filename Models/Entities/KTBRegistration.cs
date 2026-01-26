using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("KTBRegistration")]
public partial class KTBRegistration
{
    [Key]
    public int Seq { get; set; }

    public long MemberId { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? TranType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SiteName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TermId { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? TermSeq { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? AccountRef { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PostDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TranTime { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Result { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Ref1 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("KTBRegistrations")]
    public virtual Member Member { get; set; } = null!;
}
