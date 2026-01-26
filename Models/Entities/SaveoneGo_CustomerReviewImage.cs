using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class SaveoneGo_CustomerReviewImage
{
    [Key]
    public long Id { get; set; }

    public long? ReviewId { get; set; }

    [Unicode(false)]
    public string? ImageType { get; set; }

    [Unicode(false)]
    public string? ImageURL { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [ForeignKey("ReviewId")]
    [InverseProperty("SaveoneGo_CustomerReviewImages")]
    public virtual SaveoneGo_CustomerReview? Review { get; set; }
}
