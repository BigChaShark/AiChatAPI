using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("PostTransactionStatus")]
public partial class PostTransactionStatus
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    public int? Status { get; set; }

    [InverseProperty("StatusNavigation")]
    public virtual ICollection<PostTransaction> PostTransactions { get; set; } = new List<PostTransaction>();
}
