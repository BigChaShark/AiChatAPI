using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FoodWalkerDayOff")]
public partial class FoodWalkerDayOff
{
    [Key]
    public long Id { get; set; }

    public long? WalkerId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DayOff { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }
}
