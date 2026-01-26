using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("ImageShow")]
public partial class ImageShow
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string? ImageUrl { get; set; }

    public int Status { get; set; }
}
