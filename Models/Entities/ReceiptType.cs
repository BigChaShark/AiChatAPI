using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("ReceiptType")]
public partial class ReceiptType
{
    [Key]
    public int Id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public int Status { get; set; }

    [InverseProperty("RcptTypeNavigation")]
    public virtual ICollection<ReceiptIndex> ReceiptIndices { get; set; } = new List<ReceiptIndex>();

    [InverseProperty("RcptTypeNavigation")]
    public virtual ICollection<ReceiptLog> ReceiptLogs { get; set; } = new List<ReceiptLog>();

    [InverseProperty("RcptTypeNavigation")]
    public virtual ICollection<Transaction_Backup> Transaction_Backups { get; set; } = new List<Transaction_Backup>();

    [InverseProperty("RcptTypeNavigation")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
