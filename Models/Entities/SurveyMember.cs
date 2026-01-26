using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SurveyMember")]
public partial class SurveyMember
{
    [Key]
    public int Id { get; set; }

    [Unicode(false)]
    public string? Name { get; set; }

    [Unicode(false)]
    public string? Mobile { get; set; }

    [Unicode(false)]
    public string? Email { get; set; }

    [Unicode(false)]
    public string? Nationality { get; set; }

    public int? Gender { get; set; }

    public int? Age { get; set; }

    [Unicode(false)]
    public string? Occupation { get; set; }

    public int? Q1 { get; set; }

    public int? Q2 { get; set; }

    public int? Q3 { get; set; }

    public int? isAccept { get; set; }

    public int? Q4 { get; set; }

    public int? Q5 { get; set; }

    [Unicode(false)]
    public string? Opinion1 { get; set; }

    [Unicode(false)]
    public string? Opinion2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }
}
