using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("RegularLogeType")]
public partial class RegularLogeType
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Description { get; set; }

    public int? Status { get; set; }

    [InverseProperty("RegularLogeTypeNavigation")]
    public virtual ICollection<RegularLogePaymentLog> RegularLogePaymentLogs { get; set; } = new List<RegularLogePaymentLog>();

    [InverseProperty("RegularLogeType")]
    public virtual ICollection<RegularLoge> RegularLoges { get; set; } = new List<RegularLoge>();
}
