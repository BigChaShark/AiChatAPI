using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("Id", "MemberId")]
[Table("MemberProductImage")]
public partial class MemberProductImage
{
    [Key]
    public long Id { get; set; }

    [Key]
    public long MemberId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ImageName { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Price { get; set; }

    public int? Qty { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? ImageUrl { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    public int? IsMonday { get; set; }

    public int? IsTuesday { get; set; }

    public int? IsWednesday { get; set; }

    public int? IsThursday { get; set; }

    public int? IsFriday { get; set; }

    public int? IsSaturday { get; set; }

    public int? IsSunday { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? StartTime { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? EndTime { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("MemberProductImages")]
    public virtual Member Member { get; set; } = null!;

    [InverseProperty("MemberProductImage")]
    public virtual ICollection<ProductModel> ProductModels { get; set; } = new List<ProductModel>();
}
