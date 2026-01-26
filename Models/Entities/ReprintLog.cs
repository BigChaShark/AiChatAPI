using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("Seq", "TranId")]
[Table("ReprintLog")]
public partial class ReprintLog
{
    [Key]
    public int Seq { get; set; }

    [Key]
    public long TranId { get; set; }

    public int? ReprintTypeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReprintDate { get; set; }

    public string? Remark { get; set; }

    public int? CreateBy { get; set; }

    [ForeignKey("CreateBy")]
    [InverseProperty("ReprintLogs")]
    public virtual StaffUser? CreateByNavigation { get; set; }

    [ForeignKey("ReprintTypeId")]
    [InverseProperty("ReprintLogs")]
    public virtual ReprintType? ReprintType { get; set; }

    [ForeignKey("TranId")]
    [InverseProperty("ReprintLogs")]
    public virtual Transaction Tran { get; set; } = null!;
}
