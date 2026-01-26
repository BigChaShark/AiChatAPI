using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("OutstandingDebt")]
public partial class OutstandingDebt
{
    [Key]
    public int Seq { get; set; }

    [StringLength(255)]
    public string? Name { get; set; }

    [StringLength(255)]
    public string? OutstandingAmount { get; set; }

    [StringLength(255)]
    public string? Amount { get; set; }

    [StringLength(255)]
    public string? TransferDate { get; set; }

    public double? BalanceAmount { get; set; }
}
