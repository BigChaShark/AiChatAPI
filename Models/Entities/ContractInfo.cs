using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("ContractInfo")]
public partial class ContractInfo
{
    [Key]
    public int ContractInfoId { get; set; }

    [StringLength(100)]
    public string? FirstName { get; set; }

    [StringLength(100)]
    public string? LastName { get; set; }

    public int? Age { get; set; }

    [StringLength(13)]
    public string? IdentificationNo { get; set; }

    [StringLength(500)]
    public string? Address { get; set; }

    [StringLength(500)]
    public string? LogeNo { get; set; }

    public int? LogeQty { get; set; }

    [Column(TypeName = "decimal(15, 2)")]
    public decimal? Area { get; set; }

    [StringLength(50)]
    public string? Zone { get; set; }

    public int? RentalPeriodPerYear { get; set; }

    [StringLength(20)]
    public string? PayThroughAcountNo { get; set; }

    [StringLength(100)]
    public string? BranchName { get; set; }

    [StringLength(20)]
    public string? AcountNo { get; set; }

    [StringLength(50)]
    public string? AcountName { get; set; }

    [StringLength(500)]
    public string? DetailsRates { get; set; }

    public int? Fines { get; set; }

    public int? ConductBusinessQty { get; set; }

    /// <summary>
    /// 1=วัน,2=เดือน
    /// </summary>
    public byte? ConductBusinessType { get; set; }

    public int? RecognizanceAmount { get; set; }

    public int? PayEveryDayOfMonth { get; set; }

    [StringLength(500)]
    public string? Detail { get; set; }

    public int? ContractsQty { get; set; }

    public DateOnly? ContractStart { get; set; }

    public DateOnly? ContractEnd { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreateDate { get; set; }

    public int CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdateDate { get; set; }

    public int UpdateBy { get; set; }

    public int Delflag { get; set; }

    public DateOnly? OnDate { get; set; }

    [StringLength(255)]
    public string? RecognizanceAmountText { get; set; }

    [StringLength(255)]
    public string? RecognizanceDetail { get; set; }

    [StringLength(255)]
    public string? RenterName { get; set; }

    [StringLength(255)]
    public string? WitnessName { get; set; }

    [StringLength(20)]
    public string? ContractType { get; set; }
}
