using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SelectLogeFullLog")]
public partial class SelectLogeFullLog
{
    [Key]
    public int Id { get; set; }

    public long? MemberId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Zone { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LimitStatus { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("SelectLogeFullLogs")]
    public virtual Member? Member { get; set; }
}
