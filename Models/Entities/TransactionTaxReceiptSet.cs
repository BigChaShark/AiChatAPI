using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class TransactionTaxReceiptSet
{
    [Key]
    public long Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TaxMonth { get; set; }

    public int? TaxPercent { get; set; }

    public int? Status { get; set; }
}
