using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("StallMarkerLogeLimit")]
public partial class StallMarkerLogeLimit
{
    [Key]
    public int Id { get; set; }

    public long? MemberId { get; set; }

    public int? MaximumLoge { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    public int? UpdateBy { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("StallMarkerLogeLimits")]
    public virtual Member? Member { get; set; }
}
