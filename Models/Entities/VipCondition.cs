using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("VipCondition")]
public partial class VipCondition
{
    [Key]
    public int Id { get; set; }

    public long? MemberId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? Consider { get; set; }

    public int? DayOff { get; set; }

    public int? ZoneId { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    public int? UpdateBy { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("VipConditions")]
    public virtual Member? Member { get; set; }

    [ForeignKey("ZoneId")]
    [InverseProperty("VipConditions")]
    public virtual Zone? Zone { get; set; }
}
