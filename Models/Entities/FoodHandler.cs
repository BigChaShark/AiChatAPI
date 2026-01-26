using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class FoodHandler
{
    [Key]
    public long MemberId { get; set; }

    [StringLength(50)]
    public string? CardNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CardDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDate { get; set; }

    [StringLength(50)]
    public string? HandlerCardImage { get; set; }

    [StringLength(50)]
    public string? IDCardImage { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    public long? LastUpdateBy { get; set; }

    public int? Status { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("FoodHandler")]
    public virtual Member Member { get; set; } = null!;
}
