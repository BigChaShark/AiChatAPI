using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MemberCoupon")]
public partial class MemberCoupon
{
    [Key]
    public long Seq { get; set; }

    public long MemberId { get; set; }

    public long CouponId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExpiryDate { get; set; }

    public int Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UsedDate { get; set; }

    public long? ReservationLogeId { get; set; }

    [ForeignKey("CouponId")]
    [InverseProperty("MemberCoupons")]
    public virtual Coupon Coupon { get; set; } = null!;

    [ForeignKey("MemberId")]
    [InverseProperty("MemberCoupons")]
    public virtual Member Member { get; set; } = null!;

    [ForeignKey("ReservationLogeId")]
    [InverseProperty("MemberCoupons")]
    public virtual ReservationLoge? ReservationLoge { get; set; }
}
