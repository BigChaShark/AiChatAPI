using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("WalkerId", "SenderDate")]
[Table("FoodPickUpSenderDate")]
public partial class FoodPickUpSenderDate
{
    [Key]
    public long WalkerId { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime SenderDate { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }
}
