using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("PaymentGatewayMethod")]
public partial class PaymentGatewayMethod
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public int PaymentGatewayId { get; set; }

    public int Status { get; set; }

    [ForeignKey("PaymentGatewayId")]
    [InverseProperty("PaymentGatewayMethods")]
    public virtual PaymentGateway PaymentGateway { get; set; } = null!;

    [InverseProperty("PaymentGatewayMethod")]
    public virtual ICollection<TransactionDetail_Backup> TransactionDetail_Backups { get; set; } = new List<TransactionDetail_Backup>();

    [InverseProperty("PaymentGatewayMethod")]
    public virtual ICollection<TransactionDetail> TransactionDetails { get; set; } = new List<TransactionDetail>();
}
