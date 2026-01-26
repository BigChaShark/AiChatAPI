using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FoodTransactionCustomerEventLog")]
public partial class FoodTransactionCustomerEventLog
{
    [Key]
    public long Id { get; set; }

    public long? CustomerId { get; set; }

    [StringLength(200)]
    public string? EventName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("FoodTransactionCustomerEventLogs")]
    public virtual Customer? Customer { get; set; }
}
