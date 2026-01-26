using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("VipSetting")]
public partial class VipSetting
{
    [Key]
    public int Id { get; set; }

    public int? ZoneId { get; set; }

    public int? DayCount { get; set; }

    public int? IsFreeDay { get; set; }
}
