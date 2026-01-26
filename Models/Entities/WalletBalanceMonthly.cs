using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("WalletBalanceMonthly")]
public partial class WalletBalanceMonthly
{
    [Key]
    public DateOnly DateStamp { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal BalanceAmount { get; set; }
}
