using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Keyless]
[Table("SCBQrcodePayment_Backup")]
public partial class SCBQrcodePayment_Backup
{
    public long Id { get; set; }

    public long? TranId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AccessToken { get; set; }

    public int? Status { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Description { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? reference2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireDateTime { get; set; }

    [StringLength(20)]
    public string? BillerId { get; set; }

    [Unicode(false)]
    public string? Remark_Dev { get; set; }
}
