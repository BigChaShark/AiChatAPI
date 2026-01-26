using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("ReceiptLog")]
public partial class ReceiptLog
{
    [Key]
    public long Seq { get; set; }

    public long? TranId { get; set; }

    public int? RcptType { get; set; }

    public int? RcptNo { get; set; }

    public int? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [ForeignKey("CreateBy")]
    [InverseProperty("ReceiptLogs")]
    public virtual StaffUser? CreateByNavigation { get; set; }

    [ForeignKey("RcptType")]
    [InverseProperty("ReceiptLogs")]
    public virtual ReceiptType? RcptTypeNavigation { get; set; }

    [ForeignKey("TranId")]
    [InverseProperty("ReceiptLogs")]
    public virtual Transaction? Tran { get; set; }
}
