using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("GetEStampLogeRate")]
public partial class GetEStampLogeRate
{
    [Key]
    public int Id { get; set; }

    public int? ZoneId { get; set; }

    public int? LogePerStamp { get; set; }

    public long? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }
}
