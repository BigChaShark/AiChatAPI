using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Keyless]
[Table("CheckInTopupLog_Backup")]
public partial class CheckInTopupLog_Backup
{
    public long Id { get; set; }

    public int? StaffId { get; set; }

    public long? ReservationLogeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }
}
