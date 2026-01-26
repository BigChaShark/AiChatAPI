using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MemberFood")]
public partial class MemberFood
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Price { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? ImageUrl { get; set; }

    public int? FoodTypeId { get; set; }

    public int? Status { get; set; }

    public int? UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    [InverseProperty("MemberFood")]
    public virtual ICollection<DeliveryTransactionDetail> DeliveryTransactionDetails { get; set; } = new List<DeliveryTransactionDetail>();

    [ForeignKey("FoodTypeId")]
    [InverseProperty("MemberFoods")]
    public virtual FoodType? FoodType { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("MemberFoods")]
    public virtual Member? Member { get; set; }
}
