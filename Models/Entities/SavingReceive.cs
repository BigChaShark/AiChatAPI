using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("MemberId", "ReservationLogeId")]
[Table("SavingReceive")]
public partial class SavingReceive
{
    [Key]
    public long MemberId { get; set; }

    [Key]
    public long ReservationLogeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Amount { get; set; }

    public int? Status { get; set; }

    public int? ReceiveBy { get; set; }

    public int? UpdateBy { get; set; }

    public int? OTP { get; set; }

    public int? ConfirmOTP { get; set; }

    [ForeignKey("ReceiveBy")]
    [InverseProperty("SavingReceives")]
    public virtual StaffUser? ReceiveByNavigation { get; set; }

    [ForeignKey("ReservationLogeId")]
    [InverseProperty("SavingReceives")]
    public virtual ReservationLoge ReservationLoge { get; set; } = null!;
}
