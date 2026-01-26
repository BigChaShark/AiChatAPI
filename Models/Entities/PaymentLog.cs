using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("PaymentLog")]
public partial class PaymentLog
{
    [Key]
    public long Id { get; set; }

    public long? TransactionId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Amount { get; set; }

    public int? PaymentTypeId { get; set; }

    [ForeignKey("PaymentTypeId")]
    [InverseProperty("PaymentLogs")]
    public virtual PaymentType? PaymentType { get; set; }

    [ForeignKey("TransactionId")]
    [InverseProperty("PaymentLogs")]
    public virtual Transaction? Transaction { get; set; }
}
