using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("WalkerCheckIn")]
public partial class WalkerCheckIn
{
    [Key]
    public long Id { get; set; }

    public long? WalkerId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CheckInDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }
}
