using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("ShopType")]
public partial class ShopType
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Color { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Color2 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ImageUrl { get; set; }

    public int? Status { get; set; }

    public int? UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }
}
