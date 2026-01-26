using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class ToiletEquipment
{
    [Key]
    public long Id { get; set; }

    public int? ToiletZoneId { get; set; }

    public int? ToiletTypeId { get; set; }

    public int? ToiletSubTypeId { get; set; }

    [StringLength(100)]
    public string? ToiletSubTypeName { get; set; }

    [StringLength(200)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? Code { get; set; }

    public int? Status { get; set; }

    [InverseProperty("ToiletEquipment")]
    public virtual ICollection<ToiletFault> ToiletFaults { get; set; } = new List<ToiletFault>();

    [ForeignKey("ToiletTypeId")]
    [InverseProperty("ToiletEquipments")]
    public virtual ToiletType? ToiletType { get; set; }

    [ForeignKey("ToiletZoneId")]
    [InverseProperty("ToiletEquipments")]
    public virtual ToiletZone? ToiletZone { get; set; }
}
