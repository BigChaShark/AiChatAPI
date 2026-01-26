using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Keyless]
[Table("TempMP")]
public partial class TempMP
{
    [Unicode(false)]
    public string MemberId { get; set; } = null!;

    public int MP_ServiceId { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Amount { get; set; }

    [Unicode(false)]
    public string? Description { get; set; }

    public int? PaymentTypeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastedPay { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? CreateBy { get; set; }

    public int LogeAmount { get; set; }
}
