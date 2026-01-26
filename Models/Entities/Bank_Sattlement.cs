using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("Bank_Sattlement")]
public partial class Bank_Sattlement
{
    [Key]
    public long Seq { get; set; }

    public int? PaymentTypeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StatementDate { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal Amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdate { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? StaffUserId { get; set; }

    [Unicode(false)]
    public string? amountType { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    [ForeignKey("StaffUserId")]
    [InverseProperty("Bank_Sattlements")]
    public virtual StaffUser? StaffUser { get; set; }
}
