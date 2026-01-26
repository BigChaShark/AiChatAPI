using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("WalletLogType")]
public partial class WalletLogType
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public int Status { get; set; }

    public int? Status2 { get; set; }

    [InverseProperty("WalletLogType")]
    public virtual ICollection<WalletLog> WalletLogs { get; set; } = new List<WalletLog>();
}
