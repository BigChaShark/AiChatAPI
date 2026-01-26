using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("BankName")]
public partial class BankName
{
    [Key]
    public int Id { get; set; }

    [Unicode(false)]
    public string? GruupTypeName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Unicode(false)]
    public string? Name { get; set; }

    public int? EstablishedYear { get; set; }

    [Unicode(false)]
    public string? TypeName { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? SWIFTCODE { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Ab { get; set; }
}
