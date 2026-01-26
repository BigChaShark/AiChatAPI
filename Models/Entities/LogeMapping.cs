using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("LogeMapping")]
public partial class LogeMapping
{
    public int SubzoneId { get; set; }

    [Key]
    public int LogeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LogeName { get; set; }

    public int LogeIndex { get; set; }

    public int? MapSubzoneId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string MapLogeColumn { get; set; } = null!;

    public int MapLogeRow { get; set; }

    public int MapLogeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string MapLogeName { get; set; } = null!;

    public int MapLogeIndex { get; set; }

    [ForeignKey("LogeId")]
    [InverseProperty("LogeMappingLoge")]
    public virtual Loge Loge { get; set; } = null!;

    [ForeignKey("MapLogeId")]
    [InverseProperty("LogeMappingMapLoges")]
    public virtual Loge MapLoge { get; set; } = null!;
}
