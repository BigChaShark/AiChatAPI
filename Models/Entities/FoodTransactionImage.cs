using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FoodTransactionImage")]
public partial class FoodTransactionImage
{
    [Key]
    public long FoodtransactionId { get; set; }

    [StringLength(50)]
    public string? Image1 { get; set; }

    [StringLength(50)]
    public string? Image2 { get; set; }

    [StringLength(50)]
    public string? Image3 { get; set; }
}
