using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("MemberTemp")]
public partial class MemberTemp
{
    [Key]
    public long Id { get; set; }

    public long? MemberId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Password { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? IdCard { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Mobile { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ShopName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ShopType { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ShopType_1 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ShopType_2 { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ShopType_3 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LicensePlate { get; set; }

    public int? Zone1 { get; set; }

    public int? Zone2 { get; set; }

    public int? Zone3 { get; set; }

    public int? Zone4 { get; set; }

    public int? Zone5 { get; set; }

    public int? Zone2_Group { get; set; }

    public int? Zone3_Group { get; set; }

    public int? Zone5_Group { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LockerNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LockerNo2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LockerNo3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LockerNo4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LockerNo5 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Box1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Box2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Box3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Box4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Box5 { get; set; }

    public int? Status { get; set; }

    public int? UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    public int? ApproveBy { get; set; }

    public int? IsBuddy { get; set; }

    public int? IsFood { get; set; }

    public int? IsPDPA { get; set; }

    public int? IsFood5 { get; set; }

    public int? IsGrabFood { get; set; }

    public int? IsFoodPanda { get; set; }

    public int? IsLineman { get; set; }

    public int? IsShopeeFood { get; set; }
}
