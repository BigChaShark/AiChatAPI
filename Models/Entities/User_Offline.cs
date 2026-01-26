using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("User_Offline")]
public partial class User_Offline
{
    [Key]
    public long ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string UserOfflineID { get; set; } = null!;

    [Unicode(false)]
    public string Name { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Mobile { get; set; } = null!;

    public int Status { get; set; }

    public int ZoneID { get; set; }

    public int SubZoneID { get; set; }

    public int LogeQty { get; set; }

    [Unicode(false)]
    public string LogeID { get; set; } = null!;

    [Unicode(false)]
    public string LogeName { get; set; } = null!;

    [Column(TypeName = "decimal(9, 2)")]
    public decimal LogeAmount { get; set; }

    public int ElectricityID { get; set; }

    public int ElectronicID { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal ElectricityAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal ElectronicAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal TotalAmount { get; set; }

    public DateOnly CreateDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreateDateTime { get; set; }

    public int CreateBy { get; set; }
}
