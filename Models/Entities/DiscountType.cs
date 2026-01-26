using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("DiscountType")]
public partial class DiscountType
{
    [Key]
    public int Id { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public int Status { get; set; }

    [InverseProperty("DiscountType")]
    public virtual ICollection<TransactionDiscount> TransactionDiscounts { get; set; } = new List<TransactionDiscount>();
}
