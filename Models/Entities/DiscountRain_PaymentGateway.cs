using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("DiscountRain_PaymentGateway")]
public partial class DiscountRain_PaymentGateway
{
    [Key]
    public int Seq { get; set; }

    public DateOnly DiscountDate { get; set; }

    public int ZoneId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreateDate { get; set; }

    public int CreateBy { get; set; }

    public int Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CancelDate { get; set; }

    public int? CancelBy { get; set; }

    [ForeignKey("CancelBy")]
    [InverseProperty("DiscountRain_PaymentGatewayCancelByNavigations")]
    public virtual StaffUser? CancelByNavigation { get; set; }

    [ForeignKey("CreateBy")]
    [InverseProperty("DiscountRain_PaymentGatewayCreateByNavigations")]
    public virtual StaffUser CreateByNavigation { get; set; } = null!;

    [ForeignKey("ZoneId")]
    [InverseProperty("DiscountRain_PaymentGateways")]
    public virtual Zone Zone { get; set; } = null!;
}
