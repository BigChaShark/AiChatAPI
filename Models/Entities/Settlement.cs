using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("Settlement")]
public partial class Settlement
{
    [Key]
    public long Seq { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? KTB { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? SCB { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Wallet { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Saving { get; set; }
}
