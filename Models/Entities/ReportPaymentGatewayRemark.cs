using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("ReportPaymentGatewayRemark")]
public partial class ReportPaymentGatewayRemark
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    [StringLength(500)]
    public string? Remark { get; set; }
}
