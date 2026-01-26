using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class AssetCloseFault
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

    public long? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    public int? Status { get; set; }

    [ForeignKey("AssetFaultId")]
    [InverseProperty("AssetCloseFaults")]
    public virtual AssetFault? AssetFault { get; set; }
}
