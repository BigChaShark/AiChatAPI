using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SkipOTP")]
public partial class SkipOTP
{
    [Key]
    public long Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Mobile { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? UpdateBy { get; set; }

    [ForeignKey("UpdateBy")]
    [InverseProperty("SkipOTPs")]
    public virtual StaffUser? UpdateByNavigation { get; set; }
}
