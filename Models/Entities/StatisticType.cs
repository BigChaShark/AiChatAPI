using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class StatisticType
{
    [Key]
    public int Id { get; set; }

    [StringLength(500)]
    public string? Name { get; set; }

    public int? Status { get; set; }
}
