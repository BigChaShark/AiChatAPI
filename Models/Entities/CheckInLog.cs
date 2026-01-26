using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("CheckInLog")]
public partial class CheckInLog
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    public long? TranId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("CheckInLogs")]
    public virtual Member? Member { get; set; }

    [ForeignKey("TranId")]
    [InverseProperty("CheckInLogs")]
    public virtual Transaction? Tran { get; set; }
}
