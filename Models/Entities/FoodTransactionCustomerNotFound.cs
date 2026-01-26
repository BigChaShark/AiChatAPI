using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FoodTransactionCustomerNotFound")]
public partial class FoodTransactionCustomerNotFound
{
    [Key]
    public long FoodTransactionId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? WalkerId { get; set; }

    public int? Status { get; set; }
}
