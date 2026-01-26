using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("TransactionTaxRcptSetId", "TranId")]
[Table("TransactionTaxRcpts_Backup2")]
public partial class TransactionTaxRcpts_Backup2
{
    [Key]
    public long TransactionTaxRcptSetId { get; set; }

    [Key]
    public long TranId { get; set; }

    [StringLength(50)]
    public string? RcptNo { get; set; }
}
