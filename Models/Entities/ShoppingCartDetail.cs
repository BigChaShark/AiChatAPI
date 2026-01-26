using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("ShoppingCartDetail")]
public partial class ShoppingCartDetail
{
    [Key]
    public long Seq { get; set; }

    public long? ShoppingCartId { get; set; }

    public long? MenuId { get; set; }

    public int? Qty { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? Price { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? TotalPrice { get; set; }

    [ForeignKey("MenuId")]
    [InverseProperty("ShoppingCartDetails")]
    public virtual MemberMenuList? Menu { get; set; }

    [ForeignKey("ShoppingCartId")]
    [InverseProperty("ShoppingCartDetails")]
    public virtual ShoppingCart? ShoppingCart { get; set; }
}
