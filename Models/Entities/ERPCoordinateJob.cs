using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class ERPCoordinateJob
{
    [Key]
    public long Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CoordinateDate { get; set; }

    [StringLength(200)]
    public string? CustomerName { get; set; }

    [StringLength(200)]
    public string? Place { get; set; }

    [StringLength(200)]
    public string? Contact { get; set; }

    [StringLength(500)]
    public string? Purpose { get; set; }

    public int? Department1 { get; set; }

    public int? Department2 { get; set; }

    public int? Department3 { get; set; }

    public int? Department4 { get; set; }

    public int? Department5 { get; set; }

    [StringLength(200)]
    public string? OtherDepartment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    public int? Status { get; set; }
}
