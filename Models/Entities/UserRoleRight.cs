using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("UserRoleId", "RightId")]
[Table("UserRoleRight")]
public partial class UserRoleRight
{
    [Key]
    public long UserRoleId { get; set; }

    [Key]
    public int RightId { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [ForeignKey("RightId")]
    [InverseProperty("UserRoleRights")]
    public virtual Right Right { get; set; } = null!;

    [ForeignKey("UserRoleId")]
    [InverseProperty("UserRoleRights")]
    public virtual UserRole UserRole { get; set; } = null!;
}
