using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("SaveoneCallback")]
public partial class SaveoneCallback
{
    [Key]
    public int Seq { get; set; }

    public int? Id { get; set; }

    [StringLength(255)]
    public string? Name { get; set; }

    public double? Qty { get; set; }

    public double? Saving { get; set; }

    public double? Wallet { get; set; }

    public double? Amount { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Tel { get; set; }
}
