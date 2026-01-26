using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("StaffUserRight")]
public partial class StaffUserRight
{
    [Key]
    public int Seq { get; set; }

    public int StaffUserId { get; set; }

    public int RightId { get; set; }

    [ForeignKey("RightId")]
    [InverseProperty("StaffUserRights")]
    public virtual Right Right { get; set; } = null!;

    [ForeignKey("StaffUserId")]
    [InverseProperty("StaffUserRights")]
    public virtual StaffUser StaffUser { get; set; } = null!;
}
