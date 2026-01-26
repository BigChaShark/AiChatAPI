using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveonGO_TransactionGetLogeNoPaid_Backup")]
public partial class SaveonGO_TransactionGetLogeNoPaid_Backup
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
}
