using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_Member_Privilege")]
public partial class SaveoneGo_Member_Privilege
{
    [Key]
    public int Id { get; set; }

    public long? MemberId { get; set; }

    public int? PrivilegeId { get; set; }

    public long? TransactionCount { get; set; }

    public int? Status { get; set; }

    public long? LastUpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("SaveoneGo_Member_Privileges")]
    public virtual Member? Member { get; set; }

    [ForeignKey("PrivilegeId")]
    [InverseProperty("SaveoneGo_Member_Privileges")]
    public virtual SaveoneGo_MemberPrivilege? Privilege { get; set; }
}
