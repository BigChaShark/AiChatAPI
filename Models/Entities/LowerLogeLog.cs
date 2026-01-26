using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("LowerLogeLog")]
public partial class LowerLogeLog
{
    [Key]
    public long Id { get; set; }

    public long? TranId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? LogeQty { get; set; }

    public int? LowerQty { get; set; }

    [ForeignKey("TranId")]
    [InverseProperty("LowerLogeLogs")]
    public virtual Transaction? Tran { get; set; }
}
