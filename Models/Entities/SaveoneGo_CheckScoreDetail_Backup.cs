using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_CheckScoreDetail_Backup")]
public partial class SaveoneGo_CheckScoreDetail_Backup
{
    [Key]
    public long Id { get; set; }

    public long? TransactionId { get; set; }

    public long? MemberId { get; set; }

    public long? SaveoneGo_CheckScoreId { get; set; }

    public int? TopicListId { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    public int SaveoneGo_ZoneMarketId { get; set; }
}
