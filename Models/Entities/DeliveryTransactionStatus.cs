using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("DeliveryTransactionStatus")]
public partial class DeliveryTransactionStatus
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    public int? Status { get; set; }

    [InverseProperty("DeliveryTransactionStatus")]
    public virtual ICollection<DeliveryTransaction> DeliveryTransactions { get; set; } = new List<DeliveryTransaction>();
}
