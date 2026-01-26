using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("MemberId", "MP_ServiceId")]
[Table("MP_Member")]
public partial class MP_Member
{
    public int Seq { get; set; }

    [Key]
    public long MemberId { get; set; }

    [Key]
    public int MP_ServiceId { get; set; }

    [Column(TypeName = "numeric(18, 2)")]
    public decimal? Amount { get; set; }

    [Unicode(false)]
    public string? Description { get; set; }

    public int? PaymentTypeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastedPay { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? CreateBy { get; set; }

    public int LogeAmount { get; set; }

    [ForeignKey("CreateBy")]
    [InverseProperty("MP_Members")]
    public virtual StaffUser? CreateByNavigation { get; set; }

    [ForeignKey("MP_ServiceId")]
    [InverseProperty("MP_Members")]
    public virtual MP_Service MP_Service { get; set; } = null!;

    [ForeignKey("MemberId")]
    [InverseProperty("MP_Members")]
    public virtual Member Member { get; set; } = null!;

    [ForeignKey("PaymentTypeId")]
    [InverseProperty("MP_Members")]
    public virtual PaymentType? PaymentType { get; set; }
}
