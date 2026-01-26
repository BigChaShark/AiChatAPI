using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("Loge")]
public partial class Loge
{
    [Key]
    public int Id { get; set; }

    public int LogeGroupId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Unicode(false)]
    public string? Description { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal Price { get; set; }

    public int LogeSeqNo { get; set; }

    public int Status { get; set; }

    public int UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdate { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public int? IsOpen { get; set; }

    public int? IsRandom { get; set; }

    public int? IsConner { get; set; }

    public int? IsWalkWay { get; set; }

    public int? LogeOrder { get; set; }

    public int? LogeEvenOdd { get; set; }

    [InverseProperty("Loge")]
    public virtual ICollection<LogeCostMX> LogeCostMXes { get; set; } = new List<LogeCostMX>();

    [InverseProperty("Loge")]
    public virtual ICollection<LogeCost> LogeCosts { get; set; } = new List<LogeCost>();

    [ForeignKey("LogeGroupId")]
    [InverseProperty("Loges")]
    public virtual LogeGroup LogeGroup { get; set; } = null!;

    [InverseProperty("Loge")]
    public virtual LogeMapping? LogeMappingLoge { get; set; }

    [InverseProperty("MapLoge")]
    public virtual ICollection<LogeMapping> LogeMappingMapLoges { get; set; } = new List<LogeMapping>();

    [InverseProperty("Loge")]
    public virtual ICollection<LogeTemp_Master> LogeTemp_Masters { get; set; } = new List<LogeTemp_Master>();

    [InverseProperty("Loge")]
    public virtual ICollection<LogeTemp_Offline> LogeTemp_Offlines { get; set; } = new List<LogeTemp_Offline>();

    [InverseProperty("Loge")]
    public virtual ICollection<LogeTemp> LogeTemps { get; set; } = new List<LogeTemp>();

    [InverseProperty("Loge")]
    public virtual ICollection<ReservationLogeDetail> ReservationLogeDetails { get; set; } = new List<ReservationLogeDetail>();

    [InverseProperty("Loge")]
    public virtual ICollection<ReservationLogeMx> ReservationLogeMxes { get; set; } = new List<ReservationLogeMx>();

    [InverseProperty("Loge")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    [ForeignKey("UpdateBy")]
    [InverseProperty("Loges")]
    public virtual StaffUser UpdateByNavigation { get; set; } = null!;
}
