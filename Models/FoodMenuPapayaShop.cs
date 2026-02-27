using System;
using System.Collections.Generic;

namespace AiChatAPI.Models;

public partial class FoodMenuPapayaShop
{
    public long FoodId { get; set; }

    public string? FoodName { get; set; }

    public decimal Price { get; set; }

    public long Status { get; set; }

    public DateTime CreateDate { get; set; }
}
