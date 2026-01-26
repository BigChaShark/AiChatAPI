using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("RegularLoge")]
public partial class RegularLoge
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    public int? ZoneId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LogeName { get; set; }

    public int? LogeQty { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? LogeAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? ElectricAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? WaterAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? MaintenanceFee { get; set; }

    public int? RegularLogeTypeId { get; set; }

    public int? PaymentTypeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Remark { get; set; }

    public int? UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("RegularLoges")]
    public virtual Member? Member { get; set; }

    [ForeignKey("PaymentTypeId")]
    [InverseProperty("RegularLoges")]
    public virtual PaymentType? PaymentType { get; set; }

    [ForeignKey("RegularLogeTypeId")]
    [InverseProperty("RegularLoges")]
    public virtual RegularLogeType? RegularLogeType { get; set; }

    [InverseProperty("RegularLoge")]
    public virtual ICollection<RegularLoge_Invoice> RegularLoge_Invoices { get; set; } = new List<RegularLoge_Invoice>();

    [ForeignKey("ZoneId")]
    [InverseProperty("RegularLoges")]
    public virtual RegularLogeZone? Zone { get; set; }
}
