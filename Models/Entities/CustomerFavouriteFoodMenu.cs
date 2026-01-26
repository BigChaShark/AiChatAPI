using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("CustomerId", "FoodMenuId")]
[Table("CustomerFavouriteFoodMenu")]
public partial class CustomerFavouriteFoodMenu
{
    [Key]
    public long CustomerId { get; set; }

    [Key]
    public long FoodMenuId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }
}
