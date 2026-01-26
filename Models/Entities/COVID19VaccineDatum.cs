using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class COVID19VaccineDatum
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Mobile { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? VaccineName1 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Vaccine1Date { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? VaccineName2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Vaccine2Date { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? VaccineName3 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Vaccine3Date { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? VaccineName4 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Vaccine4Date { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Status { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Zone { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ImageUrl { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Remark { get; set; }

    public int? UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    [ForeignKey("MemberId")]
    [InverseProperty("COVID19VaccineData")]
    public virtual Member? Member { get; set; }
}
