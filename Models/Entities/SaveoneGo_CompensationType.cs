using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_CompensationType")]
public partial class SaveoneGo_CompensationType
{
    [Key]
    public int Id { get; set; }

    public int SaveoneGo_ZoneMarketId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Unicode(false)]
    public string? Description { get; set; }

    public int Status { get; set; }

    [InverseProperty("SaveoneGo_CompensationType")]
    public virtual ICollection<SaveoneGo_Compensation> SaveoneGo_Compensations { get; set; } = new List<SaveoneGo_Compensation>();
}
