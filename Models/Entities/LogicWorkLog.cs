using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("LogicWorkLog")]
public partial class LogicWorkLog
{
    [Key]
    public long Seq { get; set; }

    public long TransactionId { get; set; }

    public int ReservationSubzoneId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdate { get; set; }

    public int? DummyAlgorithmId { get; set; }

    [ForeignKey("DummyAlgorithmId")]
    [InverseProperty("LogicWorkLogs")]
    public virtual DummyAlgorithm? DummyAlgorithm { get; set; }

    [ForeignKey("ReservationSubzoneId")]
    [InverseProperty("LogicWorkLogs")]
    public virtual SubZone ReservationSubzone { get; set; } = null!;

    [ForeignKey("TransactionId")]
    [InverseProperty("LogicWorkLogs")]
    public virtual Transaction Transaction { get; set; } = null!;
}
