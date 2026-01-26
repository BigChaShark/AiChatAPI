using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("LogeGroupOpenDate")]
public partial class LogeGroupOpenDate
{
    [Key]
    public int LogeGroupId { get; set; }

    public int Sunday { get; set; }

    public int Monday { get; set; }

    public int Tuesday { get; set; }

    public int Wednesday { get; set; }

    public int Thursday { get; set; }

    public int Friday { get; set; }

    public int Saturday { get; set; }

    [ForeignKey("LogeGroupId")]
    [InverseProperty("LogeGroupOpenDate")]
    public virtual LogeGroup LogeGroup { get; set; } = null!;
}
