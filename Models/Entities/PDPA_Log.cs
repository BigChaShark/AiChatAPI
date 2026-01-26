using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("PDPA_Log")]
public partial class PDPA_Log
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? IpAddress { get; set; }

    public int? IsPDPA { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("PDPA_Logs")]
    public virtual Member? Member { get; set; }
}
