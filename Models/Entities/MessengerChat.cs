using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MessengerChat")]
public partial class MessengerChat
{
    [Key]
    public long Id { get; set; }

    public long? RoomId { get; set; }

    public long? CustomerId { get; set; }

    public long? AdminId { get; set; }

    [Column(TypeName = "ntext")]
    public string? Message { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? WalkerId { get; set; }

    public long? RiderId { get; set; }

    public int? RoomType { get; set; }
}
