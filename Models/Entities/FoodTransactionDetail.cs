using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FoodTransactionDetail")]
public partial class FoodTransactionDetail
{
    [Key]
    public long Id { get; set; }

    public long? FoodTransactionId { get; set; }

    [StringLength(200)]
    public string? Food { get; set; }

    [StringLength(200)]
    public string? Remark { get; set; }

    public long? TranId { get; set; }

    [StringLength(50)]
    public string? FoodImage { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Price { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    public long? LastUpdateBy { get; set; }

    public int? TransactionStatusId { get; set; }

    public long? WalkerId { get; set; }

    [StringLength(50)]
    public string? WalkerName { get; set; }

    [StringLength(50)]
    public string? WalkerMobileNo { get; set; }

    public long? FoodMenuId { get; set; }

    public int? Qty { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? SumPrice { get; set; }

    [StringLength(200)]
    public string? RejectReason { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RejectDate { get; set; }

    public long? RejectBy { get; set; }

    [ForeignKey("FoodMenuId")]
    [InverseProperty("FoodTransactionDetails")]
    public virtual FoodMenu? FoodMenu { get; set; }

    [ForeignKey("FoodTransactionId")]
    [InverseProperty("FoodTransactionDetails")]
    public virtual FoodTransaction? FoodTransaction { get; set; }

    [InverseProperty("FoodTransactionDetail")]
    public virtual ICollection<FoodTransactionDetailAddOn> FoodTransactionDetailAddOns { get; set; } = new List<FoodTransactionDetailAddOn>();

    [ForeignKey("TransactionStatusId")]
    [InverseProperty("FoodTransactionDetails")]
    public virtual FoodTransactionStatus? TransactionStatus { get; set; }
}
