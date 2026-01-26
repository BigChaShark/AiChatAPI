using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("ATKResultRecord")]
public partial class ATKResultRecord
{
    [Key]
    public int Seq { get; set; }

    public long MemberId { get; set; }

    [Unicode(false)]
    public string? ATKResult { get; set; }

    public DateOnly? ATKDate { get; set; }

    public int? Status { get; set; }

    public int? StaffUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? UpdateStaffUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdateDate { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("ATKResultRecords")]
    public virtual Member Member { get; set; } = null!;

    [ForeignKey("StaffUserId")]
    [InverseProperty("ATKResultRecordStaffUsers")]
    public virtual StaffUser? StaffUser { get; set; }

    [ForeignKey("UpdateStaffUserId")]
    [InverseProperty("ATKResultRecordUpdateStaffUsers")]
    public virtual StaffUser? UpdateStaffUser { get; set; }
}
