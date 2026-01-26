using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class BusTrip
{
    [Key]
    public long Id { get; set; }

    public long? DriverId { get; set; }

    public long? BusId { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    public int? Status { get; set; }

    [ForeignKey("BusId")]
    [InverseProperty("BusTrips")]
    public virtual SaveoneBuse? Bus { get; set; }

    [InverseProperty("Bustrip")]
    public virtual ICollection<BustripLog> BustripLogs { get; set; } = new List<BustripLog>();
}
