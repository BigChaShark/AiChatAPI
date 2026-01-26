using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MemberLeave_Backup")]
public partial class MemberLeave_Backup
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    public long? TranId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LeaveDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Remark { get; set; }

    public int? UpdateBy { get; set; }
}
