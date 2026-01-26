using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class ERPTransaction
{
    [Key]
    public long Id { get; set; }

    public int? ERPStatusId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    public long? LastUpdateBy { get; set; }

    [InverseProperty("ERPTransaction")]
    public virtual ERPAllocateLoge? ERPAllocateLoge { get; set; }

    [InverseProperty("ERPTransaction")]
    public virtual ERPCreateContract? ERPCreateContract { get; set; }

    [InverseProperty("ERPTransaction")]
    public virtual ERPOperation? ERPOperation { get; set; }

    [InverseProperty("ERPTransaction")]
    public virtual ERPReceipt? ERPReceipt { get; set; }

    [InverseProperty("ERPTransaction")]
    public virtual ERPSurveyRequirement? ERPSurveyRequirement { get; set; }
}
