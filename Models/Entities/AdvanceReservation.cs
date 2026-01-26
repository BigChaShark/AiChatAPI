using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("AdvanceReservation")]
public partial class AdvanceReservation
{
    [Key]
    public int Seq { get; set; }

    public long MemberId { get; set; }

    public int SubZoneId { get; set; }

    public int? ReservationLogeTypeId { get; set; }

    public int? ReservationLogeElectricityTypeId { get; set; }

    public int? ReservationLogeElectronicTypeId { get; set; }

    public int? PaymentTypeId { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? NextProcessDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastProcessDate { get; set; }

    public int? StaffUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    [Column(TypeName = "text")]
    public string? Remark { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("AdvanceReservations")]
    public virtual Member Member { get; set; } = null!;

    [ForeignKey("PaymentTypeId")]
    [InverseProperty("AdvanceReservations")]
    public virtual PaymentType? PaymentType { get; set; }

    [ForeignKey("ReservationLogeElectricityTypeId")]
    [InverseProperty("AdvanceReservations")]
    public virtual ReservationLogeElectricityType? ReservationLogeElectricityType { get; set; }

    [ForeignKey("ReservationLogeElectronicTypeId")]
    [InverseProperty("AdvanceReservations")]
    public virtual ReservationLogeElectronicType? ReservationLogeElectronicType { get; set; }

    [ForeignKey("ReservationLogeTypeId")]
    [InverseProperty("AdvanceReservations")]
    public virtual ReservationLogeType? ReservationLogeType { get; set; }

    [ForeignKey("StaffUserId")]
    [InverseProperty("AdvanceReservations")]
    public virtual StaffUser? StaffUser { get; set; }

    [ForeignKey("SubZoneId")]
    [InverseProperty("AdvanceReservations")]
    public virtual SubZone SubZone { get; set; } = null!;
}
