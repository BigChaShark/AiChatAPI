using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SCBRegistration")]
public partial class SCBRegistration
{
    [Key]
    public int Seq { get; set; }

    public long? MemberId { get; set; }

    [Unicode(false)]
    public string? RegisterRequest { get; set; }

    [Unicode(false)]
    public string? RegisterResponse { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegRef { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Ref_1 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? Status { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ResponseMsg { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? AccountNo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? AccountName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDate { get; set; }

    [Unicode(false)]
    public string? RegisterRequest2 { get; set; }

    [Unicode(false)]
    public string? RegisterResponse2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? AccountNo2 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? AccountName2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RegRef2 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Ref_2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ResponseMsg2 { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("SCBRegistrations")]
    public virtual Member? Member { get; set; }
}
