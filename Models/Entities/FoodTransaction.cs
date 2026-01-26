using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FoodTransaction")]
public partial class FoodTransaction
{
    [Key]
    public long Id { get; set; }

    public long? CustomerId { get; set; }

    [StringLength(200)]
    public string? CustomerName { get; set; }

    [StringLength(50)]
    public string? CustomerMobile { get; set; }

    [StringLength(200)]
    public string? Remark { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? Status { get; set; }

    [StringLength(500)]
    public string? Address { get; set; }

    public long? SenderId { get; set; }

    [StringLength(50)]
    public string? SenderMobileNo { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Price { get; set; }

    public int? Score { get; set; }

    public long? MemberId { get; set; }

    public long? TransactionId { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    [StringLength(500)]
    public string? SenderRejectReason { get; set; }

    public int? SendType { get; set; }

    public int? PaymentTypeId { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? TotalAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? DiscountAmount { get; set; }

    public long? StaffId { get; set; }

    [StringLength(50)]
    public string? DiscountCode { get; set; }

    public long? FoodTransactionCodeId { get; set; }

    public int? FoodTransactionAllianceId { get; set; }

    public int? SendType2 { get; set; }

    public int? IsAdminApprovePickUp { get; set; }

    [StringLength(500)]
    public string? TransferSlip { get; set; }

    public long? PickUpSenderId { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("FoodTransactions")]
    public virtual Customer? Customer { get; set; }

    [InverseProperty("FoodTransaction")]
    public virtual ICollection<FoodTransactionDetail> FoodTransactionDetails { get; set; } = new List<FoodTransactionDetail>();

    [ForeignKey("SenderId")]
    [InverseProperty("FoodTransactions")]
    public virtual FoodSender? Sender { get; set; }

    [ForeignKey("Status")]
    [InverseProperty("FoodTransactions")]
    public virtual FoodTransactionStatus? StatusNavigation { get; set; }
}
