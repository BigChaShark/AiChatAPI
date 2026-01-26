using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("Payin")]
public partial class Payin
{
    [Key]
    public long Seq { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PayinDate { get; set; }

    public int LogeQty { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal LogeAmountKTB { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal LogeAmountMPAY { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal LogeAmountWallet { get; set; }

    public int CancelLogeQty { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal CancelFine { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal CancelReturnToWallet { get; set; }

    public int CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreateDate { get; set; }

    public int LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdateDate { get; set; }

    [ForeignKey("CreateBy")]
    [InverseProperty("PayinCreateByNavigations")]
    public virtual StaffUser CreateByNavigation { get; set; } = null!;

    [ForeignKey("LastUpdateBy")]
    [InverseProperty("PayinLastUpdateByNavigations")]
    public virtual StaffUser LastUpdateByNavigation { get; set; } = null!;
}
