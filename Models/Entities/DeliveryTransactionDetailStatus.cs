using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("DeliveryTransactionDetailStatus")]
public partial class DeliveryTransactionDetailStatus
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    public int? Status { get; set; }

    [InverseProperty("DeliveryTransactionDetailStatus")]
    public virtual ICollection<DeliveryTransactionDetail> DeliveryTransactionDetails { get; set; } = new List<DeliveryTransactionDetail>();
}
