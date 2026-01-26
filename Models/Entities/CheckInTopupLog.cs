using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("CheckInTopupLog")]
public partial class CheckInTopupLog
{
    [Key]
    public long Id { get; set; }

    public int? StaffId { get; set; }

    public long? ReservationLogeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    [ForeignKey("ReservationLogeId")]
    [InverseProperty("CheckInTopupLogs")]
    public virtual ReservationLoge? ReservationLoge { get; set; }

    [ForeignKey("StaffId")]
    [InverseProperty("CheckInTopupLogs")]
    public virtual Staff? Staff { get; set; }
}
