using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("RegularLogeExcel")]
public partial class RegularLogeExcel
{
    [Key]
    public int Id { get; set; }

    [StringLength(255)]
    public string? Name { get; set; }

    [StringLength(255)]
    public string? Mobile { get; set; }

    public double? IdCard { get; set; }

    [StringLength(255)]
    public string? Address { get; set; }

    public int? Status { get; set; }
}
