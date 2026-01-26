using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Keyless]
public partial class View_ตรวจสอบ_ReturnError555
{
    public long TransactionId { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal AmountToPay { get; set; }

    public int TransactionStatusId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PaymentResponseCode { get; set; }

    public long Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Password { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Mobile { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreateDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }
}
