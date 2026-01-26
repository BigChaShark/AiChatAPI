using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("RegularLoge_Invoice")]
public partial class RegularLoge_Invoice
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    public long? RegularLogeId { get; set; }

    public int? RegularLogeTypeId { get; set; }

    public int? RegularLogePaymentTypeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? LogeAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? FineAmount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ElectricMeter { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? ElectricAmount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? WaterMeter { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? WaterAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? TotalAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? AmountToPay { get; set; }

    public int? InvoiceStatusId { get; set; }

    public int? UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    [ForeignKey("InvoiceStatusId")]
    [InverseProperty("RegularLoge_Invoices")]
    public virtual RegularLoge_InvoiceStatus? InvoiceStatus { get; set; }

    [ForeignKey("RegularLogeId")]
    [InverseProperty("RegularLoge_Invoices")]
    public virtual RegularLoge? RegularLoge { get; set; }

    [InverseProperty("Invoice")]
    public virtual ICollection<RegularLogePaymentLog> RegularLogePaymentLogs { get; set; } = new List<RegularLogePaymentLog>();
}
