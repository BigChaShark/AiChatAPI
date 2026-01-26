using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("ReservationLogeLimit")]
public partial class ReservationLogeLimit
{
    [Key]
    public int Seq { get; set; }

    public int? SubZoneId { get; set; }

    public int? Zone2_Group { get; set; }

    public int? LogeLimit { get; set; }

    public int? IsLogeLimit { get; set; }

    public int? SlowLimit { get; set; }

    public int? IsSlowLimit { get; set; }

    [ForeignKey("SubZoneId")]
    [InverseProperty("ReservationLogeLimits")]
    public virtual SubZone? SubZone { get; set; }
}
