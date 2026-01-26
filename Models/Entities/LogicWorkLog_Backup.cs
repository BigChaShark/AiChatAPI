using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("LogicWorkLog_Backup")]
public partial class LogicWorkLog_Backup
{
    [Key]
    public long Seq { get; set; }

    public long TransactionId { get; set; }

    public int ReservationSubzoneId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdate { get; set; }

    public int? DummyAlgorithmId { get; set; }
}
