using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_CustomerReviewList")]
public partial class SaveoneGo_CustomerReviewList
{
    [Key]
    public long Id { get; set; }

    public long? ReviewId { get; set; }

    public int? QuestionId { get; set; }

    public int? score { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    [ForeignKey("QuestionId")]
    [InverseProperty("SaveoneGo_CustomerReviewLists")]
    public virtual SaveoneGo_CustomerReviewQuestion? Question { get; set; }

    [ForeignKey("ReviewId")]
    [InverseProperty("SaveoneGo_CustomerReviewLists")]
    public virtual SaveoneGo_CustomerReview? Review { get; set; }
}
