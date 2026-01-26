using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MemberRefKey")]
public partial class MemberRefKey
{
    [Key]
    public long Seq { get; set; }

    public long? MemberId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RefKey { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }
}
