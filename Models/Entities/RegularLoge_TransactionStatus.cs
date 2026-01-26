using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("RegularLoge_TransactionStatus")]
public partial class RegularLoge_TransactionStatus
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Description { get; set; }

    public int? Status { get; set; }

    [InverseProperty("TransactionStatus")]
    public virtual ICollection<RegularLogePaymentLog> RegularLogePaymentLogs { get; set; } = new List<RegularLogePaymentLog>();
}
