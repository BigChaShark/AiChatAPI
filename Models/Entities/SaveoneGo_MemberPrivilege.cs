using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class SaveoneGo_MemberPrivilege
{
    [Key]
    public int Id { get; set; }

    [StringLength(500)]
    public string? Name { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? PercentDiscount { get; set; }

    [StringLength(10)]
    public string? ColorCode { get; set; }

    public int? Min { get; set; }

    public int? Max { get; set; }

    public string? IconSVG { get; set; }

    public string? IconPNG { get; set; }

    public int? Status { get; set; }

    public long? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    [InverseProperty("Target")]
    public virtual ICollection<SGPromotion_Target> SGPromotion_Targets { get; set; } = new List<SGPromotion_Target>();

    [InverseProperty("TargetType")]
    public virtual ICollection<SGPromotion> SGPromotions { get; set; } = new List<SGPromotion>();

    [InverseProperty("Privilege")]
    public virtual ICollection<SaveoneGo_Member_Privilege> SaveoneGo_Member_Privileges { get; set; } = new List<SaveoneGo_Member_Privilege>();

    [InverseProperty("ToPrivilege")]
    public virtual ICollection<SaveoneGo_Member_PrivilegesLog> SaveoneGo_Member_PrivilegesLogs { get; set; } = new List<SaveoneGo_Member_PrivilegesLog>();
}
