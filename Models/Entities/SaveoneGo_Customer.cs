using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_Customer")]
public partial class SaveoneGo_Customer
{
    [Key]
    public long Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? IPAddress { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Latitude { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Longitude { get; set; }

    [Unicode(false)]
    public string? Line_userId { get; set; }

    [Unicode(false)]
    public string? Line_displayName { get; set; }

    [Unicode(false)]
    public string? Line_pictureUrl { get; set; }

    [Unicode(false)]
    public string? Line_statusMessage { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    [InverseProperty("SaveoneGo_Customer")]
    public virtual ICollection<SaveoneGo_CustomerReview> SaveoneGo_CustomerReviews { get; set; } = new List<SaveoneGo_CustomerReview>();
}
