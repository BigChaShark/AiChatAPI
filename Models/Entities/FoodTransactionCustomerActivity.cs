using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class FoodTransactionCustomerActivity
{
    [Key]
    public long Id { get; set; }

    public long? CustomerId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LoginDate { get; set; }

    public int? ActivityId { get; set; }
}
