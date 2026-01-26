using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MemberMerchantCategory")]
public partial class MemberMerchantCategory
{
    [Key]
    public long Seq { get; set; }

    public long MemberId { get; set; }

    public int MerchantCategoryId { get; set; }

    public long? UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("MemberMerchantCategoryMembers")]
    public virtual Member Member { get; set; } = null!;

    [ForeignKey("MerchantCategoryId")]
    [InverseProperty("MemberMerchantCategories")]
    public virtual MerchantCategory MerchantCategory { get; set; } = null!;

    [ForeignKey("UpdateBy")]
    [InverseProperty("MemberMerchantCategoryUpdateByNavigations")]
    public virtual Member? UpdateByNavigation { get; set; }
}
