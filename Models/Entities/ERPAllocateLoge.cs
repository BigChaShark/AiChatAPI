using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class ERPAllocateLoge
{
    [Key]
    public long ERPTransactionId { get; set; }

    [StringLength(200)]
    public string? ZoneName { get; set; }

    [StringLength(200)]
    public string? LogeNo { get; set; }

    public int? LogeCount { get; set; }

    [StringLength(200)]
    public string? Area { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? RentalAmount { get; set; }

    [StringLength(50)]
    public string? PerType { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? DepositAmount { get; set; }

    [StringLength(500)]
    public string? DepositAmountNote { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OpenDate { get; set; }

    [StringLength(50)]
    public string? ElectricMeterNo { get; set; }

    [StringLength(50)]
    public string? WaterMeterNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    public long? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ContractMeetDate { get; set; }

    [ForeignKey("ERPTransactionId")]
    [InverseProperty("ERPAllocateLoge")]
    public virtual ERPTransaction ERPTransaction { get; set; } = null!;
}
