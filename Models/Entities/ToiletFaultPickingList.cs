using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class ToiletFaultPickingList
{
    [Key]
    public long Id { get; set; }

    public long? ToiletFaultId { get; set; }

    [StringLength(200)]
    public string? Description { get; set; }

    public int? Qty { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? AdminCreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AdminCreateDate { get; set; }

    [ForeignKey("ToiletFaultId")]
    [InverseProperty("ToiletFaultPickingLists")]
    public virtual ToiletFault? ToiletFault { get; set; }
}
