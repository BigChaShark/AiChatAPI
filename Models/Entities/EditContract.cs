using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("EditContract")]
public partial class EditContract
{
    [Key]
    public int EditContractId { get; set; }

    public DateOnly? SubmitDate { get; set; }

    public DateOnly? DownDate { get; set; }

    [StringLength(50)]
    public string? TitleName { get; set; }

    [StringLength(100)]
    public string? FirstName { get; set; }

    [StringLength(100)]
    public string? LastName { get; set; }

    public int? Age { get; set; }

    [StringLength(100)]
    public string? No { get; set; }

    [StringLength(100)]
    public string? Road { get; set; }

    [StringLength(100)]
    public string? SubDistrict { get; set; }

    [StringLength(100)]
    public string? District { get; set; }

    [StringLength(100)]
    public string? Province { get; set; }

    [StringLength(100)]
    public string? LogeNo { get; set; }

    public DateOnly? LeaseTermDateFrom { get; set; }

    public DateOnly? LeaseTermDateTo { get; set; }

    public int? OldRate { get; set; }

    [StringLength(255)]
    public string? OldRateText { get; set; }

    public int? NewRate { get; set; }

    [StringLength(255)]
    public string? NewRateText { get; set; }

    public DateOnly? NewRateDateFrom { get; set; }

    public DateOnly? NewRateDateTo { get; set; }

    [StringLength(255)]
    public string? RenterFirstName { get; set; }

    [StringLength(255)]
    public string? RenterLastName { get; set; }

    [StringLength(50)]
    public string? RenterTitleName { get; set; }

    public int? UpdateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public int? CreateBy { get; set; }

    public DateOnly? CreateDate { get; set; }

    public int? DelFlag { get; set; }
}
