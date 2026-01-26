using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_BanlistType")]
public partial class SaveoneGo_BanlistType
{
    [Key]
    public long Id { get; set; }

    [Unicode(false)]
    public string? BanlistType { get; set; }

    public int? Status { get; set; }
}
