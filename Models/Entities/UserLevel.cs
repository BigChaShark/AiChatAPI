using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("UserLevel")]
public partial class UserLevel
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Description { get; set; }

    public int Status { get; set; }

    public int UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdate { get; set; }

    [InverseProperty("UserLevel")]
    public virtual ICollection<StaffUser> StaffUsers { get; set; } = new List<StaffUser>();
}
