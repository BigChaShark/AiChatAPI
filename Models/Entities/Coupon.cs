using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("Coupon")]
[Index("SerialNo", Name = "IX_Coupons", IsUnique = true)]
public partial class Coupon
{
    [Key]
    public long Id { get; set; }

    public int CouponTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SerialNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreateDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExpiryDate { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal Amount { get; set; }

    public int CouponDiscountTypeId { get; set; }

    public int Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UsedDate { get; set; }

    [ForeignKey("CouponDiscountTypeId")]
    [InverseProperty("Coupons")]
    public virtual CouponDiscountType CouponDiscountType { get; set; } = null!;

    [ForeignKey("CouponTypeId")]
    [InverseProperty("Coupons")]
    public virtual CouponType CouponType { get; set; } = null!;

    [InverseProperty("Coupon")]
    public virtual ICollection<MemberCoupon> MemberCoupons { get; set; } = new List<MemberCoupon>();
}
