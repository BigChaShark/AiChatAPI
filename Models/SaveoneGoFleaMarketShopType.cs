using System;
using System.Collections.Generic;

namespace AiChatAPI.Models;

public partial class SaveoneGoFleaMarketShopType
{
    public int Id { get; set; }

    public string? TypeName { get; set; }

    public int? Status { get; set; }

    public string? Color { get; set; }

    public string? ImageUrl { get; set; }

    public virtual ICollection<SaveoneGoMemberFleaMarket> SaveoneGoMemberFleaMarkets { get; set; } = new List<SaveoneGoMemberFleaMarket>();
}
