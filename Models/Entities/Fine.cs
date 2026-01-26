using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("Fine")]
public partial class Fine
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [Column(TypeName = "decimal(9, 2)")]
    public decimal Amount { get; set; }

    public int FineTypeId { get; set; }

    public int Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdate { get; set; }

    [ForeignKey("FineTypeId")]
    [InverseProperty("Fines")]
    public virtual FineType FineType { get; set; } = null!;
}
