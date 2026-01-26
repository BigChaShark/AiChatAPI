using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("StaffId", "PromotionPeriod")]
[Table("FoodTransactionStaffDiscount")]
public partial class FoodTransactionStaffDiscount
{
    [Key]
    public long StaffId { get; set; }

    public long? FoodTransactionId { get; set; }

    [Key]
    public int PromotionPeriod { get; set; }
}
