using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Keyless]
public partial class View_WalletBalanceMonthly_ALL
{
    [Column(TypeName = "numeric(38, 2)")]
    public decimal? C1 { get; set; }

    [Column(TypeName = "numeric(38, 2)")]
    public decimal? C2 { get; set; }

    [Column(TypeName = "numeric(38, 2)")]
    public decimal? C3 { get; set; }
}
