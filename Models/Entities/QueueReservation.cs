using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("QueueDate", "MemberId")]
[Table("QueueReservation")]
public partial class QueueReservation
{
    [Key]
    public DateOnly QueueDate { get; set; }

    [Key]
    public long MemberId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string QueueRound { get; set; } = null!;

    public int QueueNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreateDate { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("QueueReservations")]
    public virtual Member Member { get; set; } = null!;
}
