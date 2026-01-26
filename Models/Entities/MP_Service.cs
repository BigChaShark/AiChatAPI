using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MP_Service")]
public partial class MP_Service
{
    [Key]
    public int Id { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Description { get; set; }

    public int Status { get; set; }

    public int? FineAmount { get; set; }

    [InverseProperty("MP_Service")]
    public virtual ICollection<MP_Member> MP_Members { get; set; } = new List<MP_Member>();

    [InverseProperty("MP_Service")]
    public virtual ICollection<MP_Transaction> MP_Transactions { get; set; } = new List<MP_Transaction>();
}
