using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("UserRole")]
public partial class UserRole
{
    [Key]
    public long Id { get; set; }

    [StringLength(200)]
    public string? Name { get; set; }

    public int? Status { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    [InverseProperty("UserRole")]
    public virtual ICollection<UserRoleRight> UserRoleRights { get; set; } = new List<UserRoleRight>();
}
