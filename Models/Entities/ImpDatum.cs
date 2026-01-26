using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Keyless]
public partial class ImpDatum
{
    public int? logeid { get; set; }

    public int? logeseqno { get; set; }
}
