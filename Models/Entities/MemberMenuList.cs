using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MemberMenuList")]
public partial class MemberMenuList
{
    [Key]
    public long Seq { get; set; }

    public long? MemberId { get; set; }

    public int? ZoneId { get; set; }

    public int? MenuCategoryId { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Price { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ImageUrl { get; set; }

    public int Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdate { get; set; }

    public long? UpdateBy { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ImageName { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("MemberMenuListMembers")]
    public virtual Member? Member { get; set; }

    [ForeignKey("MenuCategoryId")]
    [InverseProperty("MemberMenuLists")]
    public virtual MenuCategory? MenuCategory { get; set; }

    [InverseProperty("Menu")]
    public virtual ICollection<ShoppingCartDetail> ShoppingCartDetails { get; set; } = new List<ShoppingCartDetail>();

    [ForeignKey("UpdateBy")]
    [InverseProperty("MemberMenuListUpdateByNavigations")]
    public virtual Member? UpdateByNavigation { get; set; }

    [ForeignKey("ZoneId")]
    [InverseProperty("MemberMenuLists")]
    public virtual Zone? Zone { get; set; }
}
