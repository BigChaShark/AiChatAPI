using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

public partial class ERPSurveyRequirement
{
    [Key]
    public long ERPTransactionId { get; set; }

    [StringLength(50)]
    public string? ReservationId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReservaitionDate { get; set; }

    [StringLength(50)]
    public string? IdCard { get; set; }

    [StringLength(50)]
    public string? TitleName { get; set; }

    [StringLength(200)]
    public string? FirstName { get; set; }

    [StringLength(200)]
    public string? LastName { get; set; }

    [StringLength(100)]
    public string? NickName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BirthDay { get; set; }

    public int? Age { get; set; }

    [StringLength(100)]
    public string? No { get; set; }

    [StringLength(100)]
    public string? Moo { get; set; }

    [StringLength(200)]
    public string? Soi { get; set; }

    [StringLength(200)]
    public string? Road { get; set; }

    [StringLength(200)]
    public string? SubDistrict { get; set; }

    [StringLength(200)]
    public string? District { get; set; }

    [StringLength(200)]
    public string? Province { get; set; }

    [StringLength(10)]
    public string? ZipCode { get; set; }

    [StringLength(100)]
    public string? Phone { get; set; }

    [StringLength(100)]
    public string? Mobile { get; set; }

    [StringLength(200)]
    public string? Email { get; set; }

    [StringLength(50)]
    public string? Doc1 { get; set; }

    [StringLength(50)]
    public string? Doc2 { get; set; }

    [StringLength(50)]
    public string? Doc3 { get; set; }

    [StringLength(50)]
    public string? Doc4 { get; set; }

    [StringLength(50)]
    public string? Doc5 { get; set; }

    [StringLength(200)]
    public string? ProductName { get; set; }

    [StringLength(200)]
    public string? ShopName { get; set; }

    [StringLength(200)]
    public string? BusinessType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    public long? CreateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdateDate { get; set; }

    public long? LastUpdateBy { get; set; }

    [ForeignKey("ERPTransactionId")]
    [InverseProperty("ERPSurveyRequirement")]
    public virtual ERPTransaction ERPTransaction { get; set; } = null!;
}
