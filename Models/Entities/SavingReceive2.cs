using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SavingReceive2")]
public partial class SavingReceive2
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    public long? ReservationLogeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Amount { get; set; }

    public int? Status { get; set; }

    public int? ReceiveBy { get; set; }

    public int? UpdateBy { get; set; }
}
