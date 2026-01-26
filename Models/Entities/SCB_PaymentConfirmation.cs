using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SCB_PaymentConfirmation")]
public partial class SCB_PaymentConfirmation
{
    [Key]
    public long Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PayeeAccountNumber { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? PayerAccountName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SendingBankCode { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Amount { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TransactionId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TransactionDateandTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? BillPaymentRef1 { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string? ConfirmId { get; set; }

    public int? Status { get; set; }

    [StringLength(20)]
    public string? BillerId { get; set; }
}
