using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("TempCustomer")]
public partial class TempCustomer
{
    [Key]
    public long Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Mobile { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LineId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Facebook { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Password { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RegisterDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RegisterCode { get; set; }

    public int? FoodTransactionAllianceId { get; set; }

    public int? Status { get; set; }

    [StringLength(6)]
    public string? OTP { get; set; }
}
