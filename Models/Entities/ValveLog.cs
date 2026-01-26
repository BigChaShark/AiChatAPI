using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("ValveLog")]
public partial class ValveLog
{
    [Key]
    public long Id { get; set; }

    public long? ValveId { get; set; }

    public long? MemberId { get; set; }

    [Column(TypeName = "decimal(5, 1)")]
    public decimal? UseMinute { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UseStartDate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Amount { get; set; }

    public int? Status { get; set; }

    public long? TransactionId { get; set; }
}
