using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class AssetFaultLog
{
    [Key]
    public long Id { get; set; }

    public long? AssetFaultId { get; set; }

    [StringLength(500)]
    public string? Name { get; set; }

    [StringLength(100)]
    public string? Contact { get; set; }

    [StringLength(1000)]
    public string? MaintainDescription { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? Status { get; set; }

    [ForeignKey("AssetFaultId")]
    [InverseProperty("AssetFaultLogs")]
    public virtual AssetFault? AssetFault { get; set; }
}
