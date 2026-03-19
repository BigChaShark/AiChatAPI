using System;
using System.Collections.Generic;

namespace AiChatAPI.Models;

public partial class FoodCategory
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Status { get; set; }

    public long? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public long? LastUpdateBy { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public string? ImageUrl { get; set; }

    public int? FoodCategoryUseId { get; set; }
}
