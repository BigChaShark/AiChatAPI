using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FreshMarketCouponConfirm")]
public partial class FreshMarketCouponConfirm
{
    [Key]
    public long Seq { get; set; }

    public long? MemberId { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ConfirmUser { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? LogeQty { get; set; }

    public int? Amount { get; set; }
}
