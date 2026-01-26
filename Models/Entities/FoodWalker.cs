using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FoodWalker")]
public partial class FoodWalker
{
    [Key]
    public long Id { get; set; }

    [StringLength(200)]
    public string? Name { get; set; }

    [StringLength(13)]
    public string? IdCard { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Mobile { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Password { get; set; }

    [StringLength(500)]
    public string? Address { get; set; }

    [StringLength(5)]
    public string? ProvinceCode { get; set; }

    [StringLength(5)]
    public string? PostCode { get; set; }

    [StringLength(50)]
    public string? IdCardImage { get; set; }

    [StringLength(50)]
    public string? IdCardImage2 { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    public long? LastUpdateBy { get; set; }

    public long? MemberId { get; set; }
}
