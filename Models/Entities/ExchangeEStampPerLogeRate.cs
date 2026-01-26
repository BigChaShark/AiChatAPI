using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("ExchangeEStampPerLogeRate")]
public partial class ExchangeEStampPerLogeRate
{
    [Key]
    public int Id { get; set; }

    public int? ZoneId { get; set; }

    public int? StampPerLoge { get; set; }

    public long? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }
}
