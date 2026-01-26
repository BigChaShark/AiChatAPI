using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("UserTypeId", "FoodTransactionStatusId", "FlowTypeId")]
[Table("MoneyFlow")]
public partial class MoneyFlow
{
    [Key]
    public int UserTypeId { get; set; }

    [Key]
    public int FoodTransactionStatusId { get; set; }

    [Key]
    public int FlowTypeId { get; set; }

    public int? FlowTypeId2 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }
}
