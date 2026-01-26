using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class ToiletZone
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    public int? Status { get; set; }

    [InverseProperty("ToiletZone")]
    public virtual ICollection<ToiletEquipment> ToiletEquipments { get; set; } = new List<ToiletEquipment>();
}
