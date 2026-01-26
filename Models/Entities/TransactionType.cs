using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("TransactionType")]
public partial class TransactionType
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public int Status { get; set; }

    [InverseProperty("TransactionType")]
    public virtual ICollection<Transaction_Backup> Transaction_Backups { get; set; } = new List<Transaction_Backup>();

    [InverseProperty("TransactionType")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
