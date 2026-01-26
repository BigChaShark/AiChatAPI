using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SmsReservationLog")]
public partial class SmsReservationLog
{
    [Key]
    public long Seq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Sms { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SendDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Mobile { get; set; }

    public int? IsReservation { get; set; }

    public int? IsLogeFull { get; set; }
}
