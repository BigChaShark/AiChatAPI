using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("Dummy_Report")]
public partial class Dummy_Report
{
    [Key]
    public long ID { get; set; }

    public long TranID { get; set; }

    public long? DummySeq { get; set; }

    public string? Result { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }
}
