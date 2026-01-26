using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("PostTransactionDetail")]
public partial class PostTransactionDetail
{
    [Key]
    public long Id { get; set; }

    public long? PostTransactionId { get; set; }

    public int? PostType { get; set; }

    public int? Qty { get; set; }

    [ForeignKey("PostTransactionId")]
    [InverseProperty("PostTransactionDetails")]
    public virtual PostTransaction? PostTransaction { get; set; }

    [ForeignKey("PostType")]
    [InverseProperty("PostTransactionDetails")]
    public virtual PostTransactionPostType? PostTypeNavigation { get; set; }
}
