using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("ReceiptIndex")]
public partial class ReceiptIndex
{
    [Key]
    public int Seq { get; set; }

    public int RcptType { get; set; }

    public int LastRcptNo { get; set; }

    [ForeignKey("RcptType")]
    [InverseProperty("ReceiptIndices")]
    public virtual ReceiptType RcptTypeNavigation { get; set; } = null!;
}
