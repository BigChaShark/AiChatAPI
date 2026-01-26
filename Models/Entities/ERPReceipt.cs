using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class ERPReceipt
{
    [Key]
    public long ERPTransactionId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? DepositAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PayAmount { get; set; }

    [StringLength(100)]
    public string? CostType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReceiveDate { get; set; }

    public int? PeriodCount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? CashAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? ChequeAmount { get; set; }

    [StringLength(200)]
    public string? ChequeBank { get; set; }

    [StringLength(50)]
    public string? ChequeNo { get; set; }

    [StringLength(50)]
    public string? ChequeDate { get; set; }

    [StringLength(200)]
    public string? ChequeBranch { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TransferAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    public long? LastUpdateBy { get; set; }

    [ForeignKey("ERPTransactionId")]
    [InverseProperty("ERPReceipt")]
    public virtual ERPTransaction ERPTransaction { get; set; } = null!;
}
