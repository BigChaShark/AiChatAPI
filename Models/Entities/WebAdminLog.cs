using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("WebAdminLog")]
public partial class WebAdminLog
{
    [Key]
    public long Seq { get; set; }

    public int StaffUserId { get; set; }

    public int RightId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TimeStamp { get; set; }

    [ForeignKey("RightId")]
    [InverseProperty("WebAdminLogs")]
    public virtual Right Right { get; set; } = null!;

    [ForeignKey("StaffUserId")]
    [InverseProperty("WebAdminLogs")]
    public virtual StaffUser StaffUser { get; set; } = null!;
}
