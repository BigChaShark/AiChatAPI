using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("TransactionId", "PaymentGatewayMethodId", "Seq")]
[Table("TransactionDetail")]
public partial class TransactionDetail
{
    [Key]
    public long TransactionId { get; set; }

    [Key]
    public int PaymentGatewayMethodId { get; set; }

    [Key]
    public long Seq { get; set; }

    [Unicode(false)]
    public string? XMLString { get; set; }

    [ForeignKey("PaymentGatewayMethodId")]
    [InverseProperty("TransactionDetails")]
    public virtual PaymentGatewayMethod PaymentGatewayMethod { get; set; } = null!;

    [ForeignKey("TransactionId")]
    [InverseProperty("TransactionDetails")]
    public virtual Transaction Transaction { get; set; } = null!;
}
