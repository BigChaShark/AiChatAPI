using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("AdvanceReservationStatus")]
public partial class AdvanceReservationStatus
{
    [Key]
    public int ZoneId { get; set; }

    public int Status { get; set; }

    public int StaffUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdate { get; set; }

    [ForeignKey("StaffUserId")]
    [InverseProperty("AdvanceReservationStatuses")]
    public virtual StaffUser StaffUser { get; set; } = null!;

    [ForeignKey("ZoneId")]
    [InverseProperty("AdvanceReservationStatus")]
    public virtual Zone Zone { get; set; } = null!;
}
