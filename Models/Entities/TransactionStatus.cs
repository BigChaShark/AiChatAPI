using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("TransactionStatus")]
public partial class TransactionStatus
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [InverseProperty("TransactionStatus")]
    public virtual ICollection<TransactionCancel> TransactionCancels { get; set; } = new List<TransactionCancel>();

    [InverseProperty("TransactionStatus")]
    public virtual ICollection<Transaction_Backup> Transaction_Backups { get; set; } = new List<Transaction_Backup>();

    [InverseProperty("TransactionStatus")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
