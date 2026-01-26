using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("NativeApp_Notification")]
public partial class NativeApp_Notification
{
    [Key]
    public long ID { get; set; }

    public long? MemberID { get; set; }

    [StringLength(100)]
    public string? Token { get; set; }

    public string? Message { get; set; }

    public int? Reached { get; set; }

    public int? IsRead { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public int? TypeID { get; set; }
}
