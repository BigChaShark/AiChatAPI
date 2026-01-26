using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_QueueStatus")]
public partial class SaveoneGo_QueueStatus
{
    [Key]
    public int Id { get; set; }

    [Unicode(false)]
    public string? Name { get; set; }

    [Unicode(false)]
    public string? Description { get; set; }

    public int? Status { get; set; }

    [InverseProperty("StatusNavigation")]
    public virtual ICollection<SaveoneGo_Queue> SaveoneGo_Queues { get; set; } = new List<SaveoneGo_Queue>();
}
