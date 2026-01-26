using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_CustomerReviewQuestion")]
public partial class SaveoneGo_CustomerReviewQuestion
{
    [Key]
    public int Id { get; set; }

    [Unicode(false)]
    public string? QuestionDetail { get; set; }

    public int? Status { get; set; }

    [InverseProperty("Question")]
    public virtual ICollection<SaveoneGo_CustomerReviewList> SaveoneGo_CustomerReviewLists { get; set; } = new List<SaveoneGo_CustomerReviewList>();
}
