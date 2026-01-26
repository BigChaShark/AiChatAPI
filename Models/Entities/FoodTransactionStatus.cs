using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FoodTransactionStatus")]
public partial class FoodTransactionStatus
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    public int? Status { get; set; }

    [InverseProperty("TransactionStatus")]
    public virtual ICollection<FoodTransactionDetail> FoodTransactionDetails { get; set; } = new List<FoodTransactionDetail>();

    [InverseProperty("StatusNavigation")]
    public virtual ICollection<FoodTransaction> FoodTransactions { get; set; } = new List<FoodTransaction>();
}
