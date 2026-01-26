using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class ToiletFault
{
    [Key]
    public long Id { get; set; }

    public long? ToiletEquipmentId { get; set; }

    [StringLength(500)]
    public string? TellName { get; set; }

    [StringLength(100)]
    public string? TellContact { get; set; }

    [StringLength(100)]
    public string? Fault { get; set; }

    [StringLength(1000)]
    public string? Description { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReceiveDate { get; set; }

    public long? ReceiveBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompleteDate { get; set; }

    public long? CompleteBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RecheckDate { get; set; }

    public long? RecheckBy { get; set; }

    [StringLength(1000)]
    public string? MaintainDescription { get; set; }

    [StringLength(100)]
    public string? FaultImage { get; set; }

    [InverseProperty("ToiletFault")]
    public virtual ICollection<ToiletCloseFault> ToiletCloseFaults { get; set; } = new List<ToiletCloseFault>();

    [ForeignKey("ToiletEquipmentId")]
    [InverseProperty("ToiletFaults")]
    public virtual ToiletEquipment? ToiletEquipment { get; set; }

    [InverseProperty("ToiletFault")]
    public virtual ICollection<ToiletFaultLog> ToiletFaultLogs { get; set; } = new List<ToiletFaultLog>();

    [InverseProperty("ToiletFault")]
    public virtual ICollection<ToiletFaultPickingList> ToiletFaultPickingLists { get; set; } = new List<ToiletFaultPickingList>();
}
