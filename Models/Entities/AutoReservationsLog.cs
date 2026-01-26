using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("AutoReservationsLog")]
public partial class AutoReservationsLog
{
    [Key]
    public long Seq { get; set; }

    public DateOnly ProcessDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndTime { get; set; }

    public int MemberQty { get; set; }

    public int LogeQty { get; set; }

    public int? SubZoneId { get; set; }

    [ForeignKey("SubZoneId")]
    [InverseProperty("AutoReservationsLogs")]
    public virtual SubZone? SubZone { get; set; }
}
