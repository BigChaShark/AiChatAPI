using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FoodTransactionLog")]
public partial class FoodTransactionLog
{
    [Key]
    public long Id { get; set; }

    public long? FoodTransactionId { get; set; }

    public long? FoodTransactionDetailId { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? FoodTransactionStatusId { get; set; }

    public int? CreateByUserAccountType { get; set; }
}
