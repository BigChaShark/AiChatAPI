using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("FoodTransactionId", "FoodTranasctionDetailId")]
[Table("FoodtransactionDetailCancel")]
public partial class FoodtransactionDetailCancel
{
    [Key]
    public long FoodTransactionId { get; set; }

    [Key]
    public long FoodTranasctionDetailId { get; set; }

    public int? Status { get; set; }

    public long? ApproveBy { get; set; }

    [StringLength(200)]
    public string? Remark { get; set; }
}
