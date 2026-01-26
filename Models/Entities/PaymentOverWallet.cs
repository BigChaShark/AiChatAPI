using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("PaymentOverWallet")]
public partial class PaymentOverWallet
{
    [Key]
    public long Id { get; set; }

    public long? TranId { get; set; }

    public long? MemberId { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal? AmountToPay { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    public int? UpdateBy { get; set; }

    public int? Status { get; set; }

    [ForeignKey("TranId")]
    [InverseProperty("PaymentOverWallets")]
    public virtual Transaction? Tran { get; set; }
}
