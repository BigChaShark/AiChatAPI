using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("District")]
public partial class District
{
    [Key]
    [StringLength(5)]
    [Unicode(false)]
    public string Code { get; set; } = null!;

    [StringLength(5)]
    [Unicode(false)]
    public string ProvinceCode { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [ForeignKey("ProvinceCode")]
    [InverseProperty("Districts")]
    public virtual Province ProvinceCodeNavigation { get; set; } = null!;
}
