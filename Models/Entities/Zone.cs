using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("Zone")]
public partial class Zone
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Code { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Unicode(false)]
    public string? Description { get; set; }

    public int Status { get; set; }

    public int UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdate { get; set; }

    [InverseProperty("Zone")]
    public virtual AdvanceReservationStatus? AdvanceReservationStatus { get; set; }

    [InverseProperty("Zone")]
    public virtual ICollection<BlacklistMemberBooking> BlacklistMemberBookings { get; set; } = new List<BlacklistMemberBooking>();

    [InverseProperty("Zone")]
    public virtual ICollection<BlacklistMember> BlacklistMembers { get; set; } = new List<BlacklistMember>();

    [InverseProperty("Zone")]
    public virtual ICollection<DiscountRain_PaymentGateway> DiscountRain_PaymentGateways { get; set; } = new List<DiscountRain_PaymentGateway>();

    [InverseProperty("Zone")]
    public virtual ICollection<FreeDay> FreeDays { get; set; } = new List<FreeDay>();

    [InverseProperty("Zone")]
    public virtual ICollection<LogeCostByType> LogeCostByTypes { get; set; } = new List<LogeCostByType>();

    [InverseProperty("Zone")]
    public virtual ICollection<LogeCostCustom> LogeCostCustoms { get; set; } = new List<LogeCostCustom>();

    [InverseProperty("Zone")]
    public virtual ICollection<LogeGroup> LogeGroups { get; set; } = new List<LogeGroup>();

    [InverseProperty("Zone")]
    public virtual ICollection<MemberMenuList> MemberMenuLists { get; set; } = new List<MemberMenuList>();

    [InverseProperty("Zone")]
    public virtual ICollection<MemberReservationTemplate> MemberReservationTemplates { get; set; } = new List<MemberReservationTemplate>();

    [InverseProperty("Zone")]
    public virtual ICollection<MemberVip> MemberVips { get; set; } = new List<MemberVip>();

    [InverseProperty("Zone")]
    public virtual ICollection<MenuCategory> MenuCategories { get; set; } = new List<MenuCategory>();

    [InverseProperty("Zone")]
    public virtual ICollection<MerchantCategory> MerchantCategories { get; set; } = new List<MerchantCategory>();

    [InverseProperty("Zone")]
    public virtual ICollection<OpenTimeZone> OpenTimeZones { get; set; } = new List<OpenTimeZone>();

    [InverseProperty("Zone")]
    public virtual ICollection<ReservationLoge> ReservationLoges { get; set; } = new List<ReservationLoge>();

    [InverseProperty("Zone")]
    public virtual ICollection<SaveoneGo_Market> SaveoneGo_Markets { get; set; } = new List<SaveoneGo_Market>();

    [InverseProperty("Zone")]
    public virtual ICollection<SaveoneGo_ZoneMarket> SaveoneGo_ZoneMarkets { get; set; } = new List<SaveoneGo_ZoneMarket>();

    [InverseProperty("Zone")]
    public virtual ICollection<SaveoneGo_Zone_SubZone> SaveoneGo_Zone_SubZones { get; set; } = new List<SaveoneGo_Zone_SubZone>();

    [InverseProperty("Zone")]
    public virtual ICollection<SubZone> SubZones { get; set; } = new List<SubZone>();

    [ForeignKey("UpdateBy")]
    [InverseProperty("Zones")]
    public virtual StaffUser UpdateByNavigation { get; set; } = null!;

    [InverseProperty("Zone")]
    public virtual ICollection<VipCondition> VipConditions { get; set; } = new List<VipCondition>();
}
