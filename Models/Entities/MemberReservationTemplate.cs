using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MemberReservationTemplate")]
public partial class MemberReservationTemplate
{
    [Key]
    public int Seq { get; set; }

    public long MemberId { get; set; }

    public int ZoneId { get; set; }

    public int? ReservationLogeTypeId { get; set; }

    public int? ReservationLogeElectricityTypeId { get; set; }

    public int? ReservationLogeElectronicTypeId { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("MemberReservationTemplates")]
    public virtual Member Member { get; set; } = null!;

    [ForeignKey("ReservationLogeElectricityTypeId")]
    [InverseProperty("MemberReservationTemplates")]
    public virtual ReservationLogeElectricityType? ReservationLogeElectricityType { get; set; }

    [ForeignKey("ReservationLogeElectronicTypeId")]
    [InverseProperty("MemberReservationTemplates")]
    public virtual ReservationLogeElectronicType? ReservationLogeElectronicType { get; set; }

    [ForeignKey("ReservationLogeTypeId")]
    [InverseProperty("MemberReservationTemplates")]
    public virtual ReservationLogeType? ReservationLogeType { get; set; }

    [ForeignKey("ZoneId")]
    [InverseProperty("MemberReservationTemplates")]
    public virtual Zone Zone { get; set; } = null!;
}
