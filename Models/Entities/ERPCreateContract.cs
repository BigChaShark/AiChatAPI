using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class ERPCreateContract
{
    [Key]
    public long ERPTransactionId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ContractCreateDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ContractEndDate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    public long? LastUpdateBy { get; set; }

    [StringLength(50)]
    public string? AccountNo { get; set; }

    [StringLength(200)]
    public string? AccountName { get; set; }

    public int? MinimumMonth { get; set; }

    [ForeignKey("ERPTransactionId")]
    [InverseProperty("ERPCreateContract")]
    public virtual ERPTransaction ERPTransaction { get; set; } = null!;
}
