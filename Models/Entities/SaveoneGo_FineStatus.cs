using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_FineStatus")]
public partial class SaveoneGo_FineStatus
{
    [Key]
    public int Id { get; set; }

    [Unicode(false)]
    public string? Description { get; set; }
}
