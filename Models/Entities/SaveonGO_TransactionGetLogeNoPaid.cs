using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveonGO_TransactionGetLogeNoPaid")]
public partial class SaveonGO_TransactionGetLogeNoPaid
{
    [Key]
    public long Id { get; set; }

    public long TransactionId { get; set; }

    public long? MemberId { get; set; }

    public long? SaveoneGoMemberId { get; set; }

    public int? Status { get; set; }

    [StringLength(10)]
    public string? LogeName { get; set; }

    [StringLength(10)]
    public string? CreateDate { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("SaveonGO_TransactionGetLogeNoPaids")]
    public virtual Member? Member { get; set; }

    [ForeignKey("SaveoneGoMemberId")]
    [InverseProperty("SaveonGO_TransactionGetLogeNoPaids")]
    public virtual SaveoneGo_Member? SaveoneGoMember { get; set; }

    [ForeignKey("TransactionId")]
    [InverseProperty("SaveonGO_TransactionGetLogeNoPaids")]
    public virtual Transaction Transaction { get; set; } = null!;
}
