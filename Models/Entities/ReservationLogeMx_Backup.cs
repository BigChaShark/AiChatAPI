using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Keyless]
[Table("ReservationLogeMx_Backup")]
public partial class ReservationLogeMx_Backup
{
    public long TranId { get; set; }

    public int LogeId { get; set; }

    public long ReservationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TimeStamp { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }
}
