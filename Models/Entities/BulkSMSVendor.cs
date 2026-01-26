using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("BulkSMSVendor")]
public partial class BulkSMSVendor
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    public int Status { get; set; }

    [InverseProperty("BulkSMSVendor")]
    public virtual ICollection<BulkSMS_CallBack> BulkSMS_CallBacks { get; set; } = new List<BulkSMS_CallBack>();
}
