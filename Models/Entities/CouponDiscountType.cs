using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("CouponDiscountType")]
public partial class CouponDiscountType
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public int Status { get; set; }

    [InverseProperty("CouponDiscountType")]
    public virtual ICollection<Coupon> Coupons { get; set; } = new List<Coupon>();
}
