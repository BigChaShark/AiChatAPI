using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("ReservationLogeLimitLog")]
public partial class ReservationLogeLimitLog
{
    [Key]
    public long Id { get; set; }

    public int? SubZoneId { get; set; }

    public int? LogeLimit { get; set; }

    public int? SlowLimit { get; set; }
}
