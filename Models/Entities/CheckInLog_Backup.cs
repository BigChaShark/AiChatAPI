using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("CheckInLog_Backup")]
public partial class CheckInLog_Backup
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    public long? TranId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }
}
