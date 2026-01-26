using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("PostTransaction")]
public partial class PostTransaction
{
    [Key]
    public long Id { get; set; }

    [StringLength(200)]
    public string? OwnerName { get; set; }

    [StringLength(50)]
    public string? OwnerMobile { get; set; }

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

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public int? SendType { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? TotalAmount { get; set; }

    [InverseProperty("PostTransaction")]
    public virtual ICollection<PostTransactionDetail> PostTransactionDetails { get; set; } = new List<PostTransactionDetail>();

    [ForeignKey("SenderId")]
    [InverseProperty("PostTransactions")]
    public virtual FoodSender? Sender { get; set; }

    [ForeignKey("Status")]
    [InverseProperty("PostTransactions")]
    public virtual PostTransactionStatus? StatusNavigation { get; set; }
}
