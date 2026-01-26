using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("LogeType")]
public partial class LogeType
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    public int Status { get; set; }

    [InverseProperty("LogeType")]
    public virtual ICollection<LogeTemp_Offline> LogeTemp_Offlines { get; set; } = new List<LogeTemp_Offline>();

    [InverseProperty("LogeType")]
    public virtual ICollection<LogeTemp> LogeTemps { get; set; } = new List<LogeTemp>();
}
