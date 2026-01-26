using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class Staff
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Name { get; set; }

    public int Status { get; set; }

    public int UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdate { get; set; }

    [StringLength(50)]
    public string? MobileNo { get; set; }

    [InverseProperty("Staff")]
    public virtual ICollection<CheckInTopupLog> CheckInTopupLogs { get; set; } = new List<CheckInTopupLog>();

    [InverseProperty("Staff")]
    public virtual ICollection<StaffLoginLocationLog> StaffLoginLocationLogs { get; set; } = new List<StaffLoginLocationLog>();

    [InverseProperty("StaffNavigation")]
    public virtual ICollection<StaffUser> StaffUsers { get; set; } = new List<StaffUser>();

    [ForeignKey("UpdateBy")]
    [InverseProperty("Staff")]
    public virtual StaffUser UpdateByNavigation { get; set; } = null!;
}
