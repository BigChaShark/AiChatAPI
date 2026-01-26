using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("PostTransactionPostType")]
public partial class PostTransactionPostType
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    public string? Name { get; set; }

    public int? Status { get; set; }

    [InverseProperty("PostTypeNavigation")]
    public virtual ICollection<PostTransactionDetail> PostTransactionDetails { get; set; } = new List<PostTransactionDetail>();
}
