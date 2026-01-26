using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_Fine")]
public partial class SaveoneGo_Fine
{
    [Key]
    public long Id { get; set; }

    public int? LogQty_Acctual { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? LogeFine { get; set; }

    public int? ElectricityType_AcctualId { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? ElectricityFine { get; set; }

    public int? ElectronicType_AcctualId { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? ElectronicFine { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? TotalFine { get; set; }

    public long? MemberId { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    public long? TransactionId { get; set; }

    public long? New_TransactionId { get; set; }

    public int? SaveoneGo_ZoneMarketId { get; set; }

    [ForeignKey("ElectricityType_AcctualId")]
    [InverseProperty("SaveoneGo_Fines")]
    public virtual ReservationLogeElectricityType? ElectricityType_Acctual { get; set; }

    [ForeignKey("ElectronicType_AcctualId")]
    [InverseProperty("SaveoneGo_Fines")]
    public virtual ReservationLogeElectronicType? ElectronicType_Acctual { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("SaveoneGo_Fines")]
    public virtual Member? Member { get; set; }

    [ForeignKey("New_TransactionId")]
    [InverseProperty("SaveoneGo_FineNew_Transactions")]
    public virtual Transaction? New_Transaction { get; set; }

    [ForeignKey("TransactionId")]
    [InverseProperty("SaveoneGo_FineTransactions")]
    public virtual Transaction? Transaction { get; set; }
}
