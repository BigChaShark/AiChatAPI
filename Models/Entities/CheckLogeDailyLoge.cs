using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("CheckLogeDailyLoge")]
public partial class CheckLogeDailyLoge
{
    [Key]
    public int Id { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? LogeName { get; set; }

    public int? Status { get; set; }
}
