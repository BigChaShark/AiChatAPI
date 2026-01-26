using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SmsLogeFullLog")]
public partial class SmsLogeFullLog
{
    [Key]
    public long Id { get; set; }

    public int? SubZoneId { get; set; }

    public int? ZoneGroup { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }
}
