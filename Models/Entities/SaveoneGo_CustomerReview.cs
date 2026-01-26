using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_CustomerReview")]
public partial class SaveoneGo_CustomerReview
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    public long? SaveoneGo_CustomerId { get; set; }

    [Unicode(false)]
    public string? LogeName { get; set; }

    [Unicode(false)]
    public string? ReviewDetail { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? IPAddress { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Latitude { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Longitude { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("SaveoneGo_CustomerReviews")]
    public virtual Member? Member { get; set; }

    [ForeignKey("SaveoneGo_CustomerId")]
    [InverseProperty("SaveoneGo_CustomerReviews")]
    public virtual SaveoneGo_Customer? SaveoneGo_Customer { get; set; }

    [InverseProperty("Review")]
    public virtual ICollection<SaveoneGo_CustomerReviewImage> SaveoneGo_CustomerReviewImages { get; set; } = new List<SaveoneGo_CustomerReviewImage>();

    [InverseProperty("Review")]
    public virtual ICollection<SaveoneGo_CustomerReviewList> SaveoneGo_CustomerReviewLists { get; set; } = new List<SaveoneGo_CustomerReviewList>();
}
