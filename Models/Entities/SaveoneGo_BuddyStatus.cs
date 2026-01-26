using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_BuddyStatus")]
public partial class SaveoneGo_BuddyStatus
{
    [Key]
    public int Id { get; set; }

    [Unicode(false)]
    public string? Name { get; set; }

    [Unicode(false)]
    public string? Ramek { get; set; }
}
