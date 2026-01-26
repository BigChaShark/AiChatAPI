using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SmsResultLog")]
public partial class SmsResultLog
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CrateDate { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Message { get; set; }

    public int? Status { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("SmsResultLogs")]
    public virtual Member? Member { get; set; }
}
