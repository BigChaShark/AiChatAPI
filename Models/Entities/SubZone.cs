using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SubZone")]
public partial class SubZone
{
    [Key]
    public int Id { get; set; }

    public int? ZoneId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Code { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Unicode(false)]
    public string? Description { get; set; }

    public int Status { get; set; }

    public int UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VIPOpen { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VIPClose { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GeneralOpen { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GeneralClose { get; set; }

    public int SaleGroup { get; set; }

    [InverseProperty("SubZone")]
    public virtual ICollection<AdvanceReservation> AdvanceReservations { get; set; } = new List<AdvanceReservation>();

    [InverseProperty("SubZone")]
    public virtual ICollection<AutoReservationsLog> AutoReservationsLogs { get; set; } = new List<AutoReservationsLog>();

    [InverseProperty("SubZone")]
    public virtual ICollection<DummyAlgorithm> DummyAlgorithms { get; set; } = new List<DummyAlgorithm>();

    [InverseProperty("SubZone")]
    public virtual ICollection<LogeCostCustom> LogeCostCustoms { get; set; } = new List<LogeCostCustom>();

    [InverseProperty("SubZone")]
    public virtual ICollection<LogeCostMX> LogeCostMXes { get; set; } = new List<LogeCostMX>();

    [InverseProperty("SubZone")]
    public virtual ICollection<LogeCostPerDay> LogeCostPerDays { get; set; } = new List<LogeCostPerDay>();

    [InverseProperty("SubZone")]
    public virtual ICollection<LogeGroup> LogeGroups { get; set; } = new List<LogeGroup>();

    [InverseProperty("ReservationSubzone")]
    public virtual ICollection<LogicWorkLog> LogicWorkLogs { get; set; } = new List<LogicWorkLog>();

    [InverseProperty("SubZone")]
    public virtual ICollection<ReservationLogeLimit> ReservationLogeLimits { get; set; } = new List<ReservationLogeLimit>();

    [InverseProperty("SubZone")]
    public virtual ICollection<ReservationLoge> ReservationLoges { get; set; } = new List<ReservationLoge>();

    [InverseProperty("SubZone")]
    public virtual ICollection<SaveoneGo_Zone_SubZone> SaveoneGo_Zone_SubZones { get; set; } = new List<SaveoneGo_Zone_SubZone>();

    [InverseProperty("ReservationSubZone")]
    public virtual ICollection<TransactionCancel> TransactionCancels { get; set; } = new List<TransactionCancel>();

    [InverseProperty("ChangeReservationSubZone")]
    public virtual ICollection<Transaction> TransactionChangeReservationSubZones { get; set; } = new List<Transaction>();

    [InverseProperty("ReservationSubZone")]
    public virtual ICollection<Transaction> TransactionReservationSubZones { get; set; } = new List<Transaction>();

    [InverseProperty("ChangeReservationSubZone")]
    public virtual ICollection<Transaction_Backup> Transaction_BackupChangeReservationSubZones { get; set; } = new List<Transaction_Backup>();

    [InverseProperty("ReservationSubZone")]
    public virtual ICollection<Transaction_Backup> Transaction_BackupReservationSubZones { get; set; } = new List<Transaction_Backup>();

    [ForeignKey("ZoneId")]
    [InverseProperty("SubZones")]
    public virtual Zone? Zone { get; set; }
}
