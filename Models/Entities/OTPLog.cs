using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class OTPLog
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string? MobileNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [StringLength(500)]
    public string? Remark { get; set; }
}
