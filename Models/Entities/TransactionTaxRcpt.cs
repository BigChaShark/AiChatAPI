using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("TransactionTaxRcptSetId", "TranId")]
public partial class TransactionTaxRcpt
{
    [Key]
    public long TransactionTaxRcptSetId { get; set; }

    [Key]
    public long TranId { get; set; }

    [StringLength(50)]
    public string? RcptNo { get; set; }

    [ForeignKey("TranId")]
    [InverseProperty("TransactionTaxRcpts")]
    public virtual Transaction Tran { get; set; } = null!;
}
