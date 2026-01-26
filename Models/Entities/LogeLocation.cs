using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("LogeLocation")]
public partial class LogeLocation
{
    [Key]
    public int LogeId { get; set; }

    [Column(TypeName = "decimal(18, 15)")]
    public decimal? Latitude { get; set; }

    [Column(TypeName = "decimal(18, 15)")]
    public decimal? Longitude { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    public long? LastUpdateBy { get; set; }
}
