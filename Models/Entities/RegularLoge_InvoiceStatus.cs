using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("RegularLoge_InvoiceStatus")]
public partial class RegularLoge_InvoiceStatus
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Description { get; set; }

    public int? Status { get; set; }

    [InverseProperty("InvoiceStatus")]
    public virtual ICollection<RegularLoge_Invoice> RegularLoge_Invoices { get; set; } = new List<RegularLoge_Invoice>();
}
