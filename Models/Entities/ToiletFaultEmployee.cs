using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class ToiletFaultEmployee
{
    [Key]
    public long Id { get; set; }

    [StringLength(200)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? EmpCode { get; set; }

    [StringLength(50)]
    public string? Mobile { get; set; }

    public int? EmpType { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    public int? Status { get; set; }
}
