using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Keyless]
[Table("TransactionTaxRcpts_Backup")]
public partial class TransactionTaxRcpts_Backup
{
    public long TransactionTaxRcptSetId { get; set; }

    public long TranId { get; set; }

    [StringLength(50)]
    public string? RcptNo { get; set; }
}
