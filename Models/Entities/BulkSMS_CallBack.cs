using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("BulkSMS_CallBack")]
public partial class BulkSMS_CallBack
{
    [Key]
    public long Seq { get; set; }

    public int BulkSMSVendorId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TimeStamp { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Trans { get; set; }

    public int? Status { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Moble { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Message { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UsedCredit { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CreditRemain { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? DRDNStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Time { get; set; }

    [ForeignKey("BulkSMSVendorId")]
    [InverseProperty("BulkSMS_CallBacks")]
    public virtual BulkSMSVendor BulkSMSVendor { get; set; } = null!;
}
