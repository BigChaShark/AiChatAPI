using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("StaffLoginLocationLog")]
public partial class StaffLoginLocationLog
{
    [Key]
    public long Id { get; set; }

    public int? StaffId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Latitude { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Longitude { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [ForeignKey("StaffId")]
    [InverseProperty("StaffLoginLocationLogs")]
    public virtual Staff? Staff { get; set; }
}
