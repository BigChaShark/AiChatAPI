using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("CheckLogeDaily")]
public partial class CheckLogeDaily
{
    [Key]
    public long Id { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Loge { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MemberName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? Status { get; set; }

    public int? IsRaining { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? StartRainingTime { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? EndRainingTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CheckerBy { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RecordBy { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SendBy { get; set; }

    public int? UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }
}
