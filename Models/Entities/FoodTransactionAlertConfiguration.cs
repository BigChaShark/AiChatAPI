using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("FoodTransactionAlertConfiguration")]
public partial class FoodTransactionAlertConfiguration
{
    [Key]
    public int Id { get; set; }

    public int StepId { get; set; }

    public int NoticeId { get; set; }

    public int? Status { get; set; }
}
