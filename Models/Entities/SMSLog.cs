using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SMSLog")]
public partial class SMSLog
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? messageId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? message { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ToNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FromSender { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? sentAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? doneAt { get; set; }

    public int? smsCount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? pricePerMessage { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? priceCurrency { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? callbackData { get; set; }

    public int? statusgroupId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? statusgroupName { get; set; }

    public int? statusid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? statusname { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? statusdescription { get; set; }

    public int? errorgroupId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? errorroupName { get; set; }

    public int? errorrid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? errorname { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? errordescription { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? errorpermanent { get; set; }
}
