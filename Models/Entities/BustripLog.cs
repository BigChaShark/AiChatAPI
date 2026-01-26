using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class BustripLog
{
    [Key]
    public long Id { get; set; }

    public long? BustripId { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [ForeignKey("BustripId")]
    [InverseProperty("BustripLogs")]
    public virtual BusTrip? Bustrip { get; set; }
}
