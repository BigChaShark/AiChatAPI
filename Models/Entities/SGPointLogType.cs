using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class SGPointLogType
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Description_ForMember { get; set; }

    public int Status { get; set; }

    public int? Status2 { get; set; }

    [InverseProperty("SGPointLogType")]
    public virtual ICollection<SGPointLog> SGPointLogs { get; set; } = new List<SGPointLog>();
}
