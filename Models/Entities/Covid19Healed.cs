using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("Covid19Healed")]
public partial class Covid19Healed
{
    [Key]
    public long MemberId { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("Covid19Healed")]
    public virtual Member Member { get; set; } = null!;
}
