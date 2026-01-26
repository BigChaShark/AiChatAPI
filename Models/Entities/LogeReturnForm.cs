using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("LogeReturnForm")]
public partial class LogeReturnForm
{
    [Key]
    public long Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? TitleName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Loge { get; set; }

    public int? LogeQty { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ShopType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Mobile { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PaidDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AdmitDate { get; set; }

    public int? IsCash { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CashDate { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? CashAmount { get; set; }

    public int? IsTransfer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TransferDate { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? TransferAmount { get; set; }

    public int? IsInstallment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Installment1Date { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Installment1Amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Cheque1Date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Installment2Date { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Installment2Amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Cheque2Date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Installment3Date { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Installment3Amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Cheque3Date { get; set; }

    public int? IsElectriccity { get; set; }

    public int? IsPropertyTax { get; set; }

    public int? IsDamaged { get; set; }

    public int? IsDeposit { get; set; }

    public int? IsOther { get; set; }

    public int? UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }
}
