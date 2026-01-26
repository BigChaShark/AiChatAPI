using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class SGSaving
{
    [Key]
    public long Seq { get; set; }

    public long MemberId { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal? BalanceAmount { get; set; }
}
