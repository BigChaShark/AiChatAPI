using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class SaveoneGo_MemberImage
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    public long? SaveoneGo_MemberId { get; set; }

    [Unicode(false)]
    public string? ImageType { get; set; }

    [Unicode(false)]
    public string? ImageURL { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("SaveoneGo_MemberImages")]
    public virtual Member? Member { get; set; }

    [ForeignKey("SaveoneGo_MemberId")]
    [InverseProperty("SaveoneGo_MemberImages")]
    public virtual SaveoneGo_Member? SaveoneGo_Member { get; set; }
}
