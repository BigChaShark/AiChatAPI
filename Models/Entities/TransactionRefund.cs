using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class TransactionRefund
{
    [Key]
    public long TransactionId { get; set; }

    public int? TypeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    public int? IsOnlyLogeAmount { get; set; }

    public int? Status { get; set; }
}
