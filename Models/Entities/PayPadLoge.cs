using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("PayPadLoge")]
public partial class PayPadLoge
{
    [Key]
    public long Id { get; set; }

    public long? ReservationLogeId { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? SumAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? PayAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? RefundAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    public int? Status { get; set; }
}
