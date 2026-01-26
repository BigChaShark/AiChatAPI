using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_Queue")]
public partial class SaveoneGo_Queue
{
    [Key]
    public long Id { get; set; }

    public int? SaveoneGo_ZoneMarketId { get; set; }

    public long? MemberId { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int TransactionStatusId { get; set; }

    public int? ZoneId { get; set; }

    public int? ReservationSubZoneId { get; set; }

    public int? ReservationLogeTypeId { get; set; }

    public int? ReservationLogeElectricityTypeId { get; set; }

    public int? ReservationLogeElectronicTypeId { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? ReservationElectricityAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? ReservationElectronicAmount { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal? ReservationLogeAmount { get; set; }

    [Column(TypeName = "numeric(9, 2)")]
    public decimal? AmountToPay { get; set; }

    public int? isChangeZone { get; set; }

    public long? TranId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TranBillNo { get; set; }

    public int? isUseGoPoint { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SellingDate { get; set; }

    public int? isAdvanceBooking { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("SaveoneGo_Queues")]
    public virtual Member? Member { get; set; }

    [ForeignKey("SaveoneGo_ZoneMarketId")]
    [InverseProperty("SaveoneGo_Queues")]
    public virtual SaveoneGo_ZoneMarket? SaveoneGo_ZoneMarket { get; set; }

    [ForeignKey("Status")]
    [InverseProperty("SaveoneGo_Queues")]
    public virtual SaveoneGo_QueueStatus? StatusNavigation { get; set; }
}
