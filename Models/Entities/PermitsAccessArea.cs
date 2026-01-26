using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("PermitsAccessArea")]
public partial class PermitsAccessArea
{
    [Key]
    public long Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? TitleName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VillageNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Road { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Subdistrict { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? District { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Province { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Telephone { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Company { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? CompanyTel { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LogeNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MemberLoge { get; set; }

    public int? Qty { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Worker1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Worker2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Worker3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Worker4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Worker5 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Worker6 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    public int? UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }
}
