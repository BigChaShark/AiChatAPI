using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneGo_Member_PrivilegesLog")]
public partial class SaveoneGo_Member_PrivilegesLog
{
    [Key]
    public int Id { get; set; }

    public long? MemberId { get; set; }

    public int? ToPrivilegeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("SaveoneGo_Member_PrivilegesLogs")]
    public virtual Member? Member { get; set; }

    [ForeignKey("ToPrivilegeId")]
    [InverseProperty("SaveoneGo_Member_PrivilegesLogs")]
    public virtual SaveoneGo_MemberPrivilege? ToPrivilege { get; set; }
}
