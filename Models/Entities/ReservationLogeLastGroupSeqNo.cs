using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("ReservationLogeLastGroupSeqNo")]
public partial class ReservationLogeLastGroupSeqNo
{
    [Key]
    public long Seq { get; set; }

    public int LastGroupSeqNo { get; set; }

    public long ReservationDate { get; set; }
}
