using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MUSaving")]
public partial class MUSaving
{
    [Key]
    public long Seq { get; set; }

    public long MemberId { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal? BalanceAmount { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("MUSavings")]
    public virtual Member Member { get; set; } = null!;
}
