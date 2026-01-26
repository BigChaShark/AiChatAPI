using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("ReservationLogeAdditional")]
public partial class ReservationLogeAdditional
{
    [Key]
    public long Id { get; set; }

    public long? ReservationLogeId { get; set; }

    public long? MemberId { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? LogeAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? ElectricityAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? CarParkAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? AreaAmount { get; set; }

    public int? Status { get; set; }

    public int? UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? SubleaseAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? SwitchLogeAmount { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("ReservationLogeAdditionals")]
    public virtual Member? Member { get; set; }

    [ForeignKey("ReservationLogeId")]
    [InverseProperty("ReservationLogeAdditionals")]
    public virtual ReservationLoge? ReservationLoge { get; set; }

    [ForeignKey("UpdateBy")]
    [InverseProperty("ReservationLogeAdditionals")]
    public virtual StaffUser? UpdateByNavigation { get; set; }
}
