using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("MemberId", "PromotionPeriod")]
[Table("FoodTransactionMerchantDiscount")]
public partial class FoodTransactionMerchantDiscount
{
    [Key]
    public long MemberId { get; set; }

    public long? FoodTransactionId { get; set; }

    [Key]
    public int PromotionPeriod { get; set; }
}
