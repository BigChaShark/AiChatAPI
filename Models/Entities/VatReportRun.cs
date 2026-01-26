using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class VatReportRun
{
    [Key]
    public int Id { get; set; }

    public int PercentRun { get; set; }
}
