using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("ReservationLogeElectronicType")]
public partial class ReservationLogeElectronicType
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public int? Price { get; set; }

    public int Status { get; set; }

    public int? Watt { get; set; }

    [InverseProperty("ReservationLogeElectronicType")]
    public virtual ICollection<AdvanceReservation> AdvanceReservations { get; set; } = new List<AdvanceReservation>();

    [InverseProperty("ReservationLogeElectronicType")]
    public virtual ICollection<MemberReservationTemplate> MemberReservationTemplates { get; set; } = new List<MemberReservationTemplate>();

    [InverseProperty("ElectronicType_Acctual")]
    public virtual ICollection<SaveoneGo_Fine> SaveoneGo_Fines { get; set; } = new List<SaveoneGo_Fine>();

    [InverseProperty("ReservationLogeElectronicType")]
    public virtual ICollection<Transaction_Backup> Transaction_Backups { get; set; } = new List<Transaction_Backup>();

    [InverseProperty("ReservationLogeElectronicType")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
