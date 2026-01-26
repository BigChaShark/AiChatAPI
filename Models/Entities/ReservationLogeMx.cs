using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("TranId", "LogeId", "ReservationDate")]
[Table("ReservationLogeMx")]
public partial class ReservationLogeMx
{
    [Key]
    public long TranId { get; set; }

    [Key]
    public int LogeId { get; set; }

    [Key]
    public long ReservationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TimeStamp { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    [ForeignKey("LogeId")]
    [InverseProperty("ReservationLogeMxes")]
    public virtual Loge Loge { get; set; } = null!;

    [ForeignKey("TranId")]
    [InverseProperty("ReservationLogeMxes")]
    public virtual Transaction Tran { get; set; } = null!;
}
