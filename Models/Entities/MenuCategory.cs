using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MenuCategory")]
public partial class MenuCategory
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "text")]
    public string? Description { get; set; }

    public int? Status { get; set; }

    public int? ZoneId { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Image_Url { get; set; }

    public int? UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    [InverseProperty("MenuCategory")]
    public virtual ICollection<MemberMenuList> MemberMenuLists { get; set; } = new List<MemberMenuList>();

    [ForeignKey("UpdateBy")]
    [InverseProperty("MenuCategories")]
    public virtual StaffUser? UpdateByNavigation { get; set; }

    [ForeignKey("ZoneId")]
    [InverseProperty("MenuCategories")]
    public virtual Zone? Zone { get; set; }
}
