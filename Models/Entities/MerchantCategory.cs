using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MerchantCategory")]
public partial class MerchantCategory
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Description { get; set; }

    public int? Status { get; set; }

    public int ZoneId { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Image_Url { get; set; }

    public int? UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    [InverseProperty("MerchantCategory")]
    public virtual ICollection<MemberMerchantCategory> MemberMerchantCategories { get; set; } = new List<MemberMerchantCategory>();

    [ForeignKey("UpdateBy")]
    [InverseProperty("MerchantCategories")]
    public virtual StaffUser? UpdateByNavigation { get; set; }

    [ForeignKey("ZoneId")]
    [InverseProperty("MerchantCategories")]
    public virtual Zone Zone { get; set; } = null!;
}
