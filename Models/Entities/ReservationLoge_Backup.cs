using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("ReservationLoge_Backup")]
public partial class ReservationLoge_Backup
{
    [Key]
    public long Id { get; set; }

    public long MemberId { get; set; }

    public int? ZoneId { get; set; }

    public int LogeQty { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string LogeName { get; set; } = null!;

    [Column(TypeName = "decimal(9, 2)")]
    public decimal LogeAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal ElectricityAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal ElectronicAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal DiscountAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal TotalAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal FullAreaAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal FineAmount { get; set; }

    public int Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreateDate { get; set; }

    public int? SubZoneId { get; set; }

    public int? IsEntrance { get; set; }

    public int? ReservationStatus { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? SavingAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PaymentFee { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? EStampAmount { get; set; }
}
