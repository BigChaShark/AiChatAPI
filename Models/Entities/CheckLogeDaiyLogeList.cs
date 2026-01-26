using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("CheckLogeDaiyLogeList")]
public partial class CheckLogeDaiyLogeList
{
    [Key]
    public int Id { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? LogeName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MemberName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    public int? UpdateBy { get; set; }
}
