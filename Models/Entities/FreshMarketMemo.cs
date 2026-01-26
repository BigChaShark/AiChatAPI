using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[PrimaryKey("MemberId", "MemoDate")]
[Table("FreshMarketMemo")]
public partial class FreshMarketMemo
{
    [Key]
    public long MemberId { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime MemoDate { get; set; }

    [Column(TypeName = "ntext")]
    public string? Description { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }
}
