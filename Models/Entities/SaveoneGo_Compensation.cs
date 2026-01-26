using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_Compensation")]
public partial class SaveoneGo_Compensation
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    public int? SaveoneGo_ZoneMarketId { get; set; }

    public int? SaveoneGo_CompensationTypeId { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    public int? Status { get; set; }

    public int? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? SaveoneGo_MemberId { get; set; }

    public long? SaveoneGo_Member_FleaMarketId { get; set; }

    public int? isOneTimeUse { get; set; }

    public int? isUse { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDateTime { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("SaveoneGo_Compensations")]
    public virtual Member? Member { get; set; }

    [ForeignKey("SaveoneGo_CompensationTypeId")]
    [InverseProperty("SaveoneGo_Compensations")]
    public virtual SaveoneGo_CompensationType? SaveoneGo_CompensationType { get; set; }
}
