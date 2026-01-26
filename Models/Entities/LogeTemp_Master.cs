using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("LogeId", "OpenCase")]
[Table("LogeTemp_Master")]
public partial class LogeTemp_Master
{
    [Key]
    public int LogeId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string LogeName { get; set; } = null!;

    public int LogeTypeId { get; set; }

    public int LogeIndex { get; set; }

    public int IsConner { get; set; }

    /// <summary>
    /// 1 = จันทร์ - พฤหัส , 2 = ศุกร์ - อาทิตย์
    /// </summary>
    [Key]
    public int OpenCase { get; set; }

    public int Status { get; set; }

    [ForeignKey("LogeId")]
    [InverseProperty("LogeTemp_Masters")]
    public virtual Loge Loge { get; set; } = null!;
}
