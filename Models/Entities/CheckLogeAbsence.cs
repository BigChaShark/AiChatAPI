using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("CheckLogeAbsence")]
public partial class CheckLogeAbsence
{
    [Key]
    public long ReservationLogeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    [ForeignKey("ReservationLogeId")]
    [InverseProperty("CheckLogeAbsence")]
    public virtual ReservationLoge ReservationLoge { get; set; } = null!;
}
