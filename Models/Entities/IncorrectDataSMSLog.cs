using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class IncorrectDataSMSLog
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    [StringLength(50)]
    public string? MobileNo { get; set; }

    [StringLength(300)]
    public string? Message { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }
}
