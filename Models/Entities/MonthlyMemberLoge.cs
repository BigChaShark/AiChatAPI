using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MonthlyMemberLoge")]
public partial class MonthlyMemberLoge
{
    [Key]
    public long MemberId { get; set; }

    [StringLength(500)]
    public string? LogeName { get; set; }
}
