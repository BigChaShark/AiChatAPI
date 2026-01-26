using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FreshMarketReservationLoge")]
public partial class FreshMarketReservationLoge
{
    [Key]
    public long Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MemberId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ZoneId { get; set; }

    public int? LogeQty { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LogeName { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? LogeAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? ElectricityAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? ElectronicAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? DiscountAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? TotalAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? FullAreaAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? FineAmount { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? SubZoneId { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string? IDCard { get; set; }
}
