using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MajorCustomerInfo")]
public partial class MajorCustomerInfo
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? WorkingTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Contact { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ImageUrl { get; set; }

    [Column(TypeName = "text")]
    public string? Remark { get; set; }

    public int Status { get; set; }
}
