using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("ReservationLogeElectricityType")]
public partial class ReservationLogeElectricityType
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public int? Price { get; set; }

    public int Status { get; set; }

    [InverseProperty("ReservationLogeElectricityType")]
    public virtual ICollection<AdvanceReservation> AdvanceReservations { get; set; } = new List<AdvanceReservation>();

    [InverseProperty("ReservationLogeElectricityType")]
    public virtual ICollection<MemberReservationTemplate> MemberReservationTemplates { get; set; } = new List<MemberReservationTemplate>();

    [InverseProperty("ElectricityType_Acctual")]
    public virtual ICollection<SaveoneGo_Fine> SaveoneGo_Fines { get; set; } = new List<SaveoneGo_Fine>();

    [InverseProperty("ReservationLogeElectricityType")]
    public virtual ICollection<Transaction_Backup> Transaction_Backups { get; set; } = new List<Transaction_Backup>();

    [InverseProperty("ReservationLogeElectricityType")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
