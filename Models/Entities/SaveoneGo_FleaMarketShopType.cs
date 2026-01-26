using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_FleaMarketShopType")]
public partial class SaveoneGo_FleaMarketShopType
{
    [Key]
    public int Id { get; set; }

    [Unicode(false)]
    public string? TypeName { get; set; }

    public int? Status { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Color { get; set; }

    [Unicode(false)]
    public string? ImageUrl { get; set; }

    [InverseProperty("FleaMarketShopType")]
    public virtual ICollection<SaveoneGo_Member_FleaMarket> SaveoneGo_Member_FleaMarkets { get; set; } = new List<SaveoneGo_Member_FleaMarket>();
}
