using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("Right")]
public partial class Right
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Url { get; set; }

    public int Status { get; set; }

    public int UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdate { get; set; }

    [InverseProperty("Right")]
    public virtual ICollection<StaffUserRight> StaffUserRights { get; set; } = new List<StaffUserRight>();

    [InverseProperty("Right")]
    public virtual ICollection<UserRoleRight> UserRoleRights { get; set; } = new List<UserRoleRight>();

    [InverseProperty("Right")]
    public virtual ICollection<WebAdminLog> WebAdminLogs { get; set; } = new List<WebAdminLog>();
}
