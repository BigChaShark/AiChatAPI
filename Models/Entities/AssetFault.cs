using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class AssetFault
{
    [Key]
    public long Id { get; set; }

    public long? AssetId { get; set; }

    [StringLength(500)]
    public string? TellName { get; set; }

    [StringLength(100)]
    public string? TellContact { get; set; }

    [StringLength(100)]
    public string? Fault { get; set; }

    [StringLength(1000)]
    public string? Description { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    public int? Status { get; set; }

    [ForeignKey("AssetId")]
    [InverseProperty("AssetFaults")]
    public virtual Asset? Asset { get; set; }

    [InverseProperty("AssetFault")]
    public virtual ICollection<AssetCloseFault> AssetCloseFaults { get; set; } = new List<AssetCloseFault>();

    [InverseProperty("AssetFault")]
    public virtual ICollection<AssetFaultLog> AssetFaultLogs { get; set; } = new List<AssetFaultLog>();
}
