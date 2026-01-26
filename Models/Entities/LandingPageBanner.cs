using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("LandingPageBanner")]
public partial class LandingPageBanner
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string? ImageURL { get; set; }

    [StringLength(50)]
    public string? RedirectURL { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }
}
