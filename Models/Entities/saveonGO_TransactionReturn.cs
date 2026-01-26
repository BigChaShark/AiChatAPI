using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("saveonGO_TransactionReturn")]
public partial class saveonGO_TransactionReturn
{
    [Key]
    public long Id { get; set; }

    public long TransactionId { get; set; }

    public long? SaveoneGoMemberId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BankCode { get; set; }

    [Unicode(false)]
    public string? BankName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? BankAccountNo { get; set; }

    [Unicode(false)]
    public string? BankAccountName { get; set; }

    public int? Status { get; set; }

    [ForeignKey("SaveoneGoMemberId")]
    [InverseProperty("saveonGO_TransactionReturns")]
    public virtual SaveoneGo_Member? SaveoneGoMember { get; set; }

    [ForeignKey("TransactionId")]
    [InverseProperty("saveonGO_TransactionReturns")]
    public virtual Transaction Transaction { get; set; } = null!;
}
