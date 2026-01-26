using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Keyless]
[Table("ReservationLogeDetail_Backup")]
public partial class ReservationLogeDetail_Backup
{
    public long? ReservationLogeId { get; set; }

    public int LogeId { get; set; }

    public long ReservationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TimeStamp { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    public long? EStampId { get; set; }
}
