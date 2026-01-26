using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("LogeId", "ReservationDate")]
[Table("ReservationLogeDetail")]
public partial class ReservationLogeDetail
{
    public long? ReservationLogeId { get; set; }

    [Key]
    public int LogeId { get; set; }

    [Key]
    public long ReservationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TimeStamp { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    public long? EStampId { get; set; }

    [ForeignKey("LogeId")]
    [InverseProperty("ReservationLogeDetails")]
    public virtual Loge Loge { get; set; } = null!;

    [ForeignKey("ReservationLogeId")]
    [InverseProperty("ReservationLogeDetails")]
    public virtual ReservationLoge? ReservationLoge { get; set; }
}
