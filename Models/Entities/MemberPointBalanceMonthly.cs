using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Keyless]
[Table("MemberPointBalanceMonthly")]
public partial class MemberPointBalanceMonthly
{
    public DateOnly DateStamp { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal BalanceAmount { get; set; }
}
