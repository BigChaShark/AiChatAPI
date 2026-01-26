using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("ProductModel")]
public partial class ProductModel
{
    [Key]
    public long Id { get; set; }

    public long ProductId { get; set; }

    public long MemberId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ModelName { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? ModelPrice { get; set; }

    [InverseProperty("ProductModel")]
    public virtual ICollection<DeliveryDetail> DeliveryDetails { get; set; } = new List<DeliveryDetail>();

    [ForeignKey("ProductId, MemberId")]
    [InverseProperty("ProductModels")]
    public virtual MemberProductImage MemberProductImage { get; set; } = null!;
}
