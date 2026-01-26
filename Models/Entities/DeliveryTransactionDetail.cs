using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("DeliveryTransactionDetail")]
public partial class DeliveryTransactionDetail
{
    [Key]
    public long Id { get; set; }

    public long? DeliveryTransactionId { get; set; }

    public long MemberFoodId { get; set; }

    [StringLength(200)]
    public string? Food { get; set; }

    [StringLength(200)]
    public string? Remark { get; set; }

    public long? TranId { get; set; }

    [StringLength(50)]
    public string? FoodImage { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Price { get; set; }

    public int? Qty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    public long? LastUpdateBy { get; set; }

    public int? DeliveryTransactionDetailStatusId { get; set; }

    [StringLength(50)]
    public string? RiderName { get; set; }

    [StringLength(50)]
    public string? RiderMobileNo { get; set; }

    [ForeignKey("DeliveryTransactionId")]
    [InverseProperty("DeliveryTransactionDetails")]
    public virtual DeliveryTransaction? DeliveryTransaction { get; set; }

    [ForeignKey("DeliveryTransactionDetailStatusId")]
    [InverseProperty("DeliveryTransactionDetails")]
    public virtual DeliveryTransactionDetailStatus? DeliveryTransactionDetailStatus { get; set; }

    [ForeignKey("MemberFoodId")]
    [InverseProperty("DeliveryTransactionDetails")]
    public virtual MemberFood MemberFood { get; set; } = null!;
}
