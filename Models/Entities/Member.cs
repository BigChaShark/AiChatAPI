using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("Member")]
public partial class Member
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Code { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Prefix { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NickName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UserName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Password { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RegisterDate { get; set; }

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
    public string? AddressNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Moo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Soi { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Road { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SubDistrict { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? District { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Province { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Postcode { get; set; }

    [Unicode(false)]
    public string? Remark { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LicensePlate { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ImagePersonUrl { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ImageIdCardUrl { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ImageHomeRegistrationUrl { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FacebookId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? InstagramId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    public int? Zone1 { get; set; }

    public int? Zone2 { get; set; }

    public int? Zone3 { get; set; }

    public int? Zone4 { get; set; }

    public int? Zone5 { get; set; }

    public int? Zone2_Group { get; set; }

    public int? Zone3_Group { get; set; }

    public int? Zone5_Group { get; set; }

    public int? IsAdmin { get; set; }

    public int? IsVIPZone1 { get; set; }

    public int? IsVIPZone2 { get; set; }

    public int? IsVIPZone3 { get; set; }

    public int? IsVIPZone4 { get; set; }

    public int? IsVIPZone5 { get; set; }

    public int? IsVIPStatusZone2 { get; set; }

    public int? IsVIPStatusZone2_2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndVipZone2Date { get; set; }

    public int? IsVIPStatusZone3 { get; set; }

    public int? IsVIPStatusZone3_2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndVipZone3Date { get; set; }

    public int? IsVIPStatusZone5 { get; set; }

    public int? IsVIPStatusZone5_2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndVipZone5Date { get; set; }

    public int? IsResCon { get; set; }

    public int? IsResConMax { get; set; }

    public int? IsResConZone2 { get; set; }

    public int? IsResConZone3 { get; set; }

    public int? IsResConZone5 { get; set; }

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

    public int? IsCancel { get; set; }

    public int? IsOTPReservationLast4IDCard { get; set; }

    public int? IsLoginOTP { get; set; }

    public int? IsUpdateMobile { get; set; }

    public int? OtherImage { get; set; }

    [Unicode(false)]
    public string? OtherImageNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? IdCard2 { get; set; }

    public int? IsOverWallet { get; set; }

    public int? IsShowKTPRegister { get; set; }

    public int? IsShowSCBRegister { get; set; }

    public int? IsNotMobile { get; set; }

    public int? Status { get; set; }

    public int? IsCripple { get; set; }

    public int? IsDetechOneMoreIP { get; set; }

    public int? IsWalletNotAdmin { get; set; }

    public int? IsBuddy { get; set; }

    public int? IsRecommend { get; set; }

    public int? IsDelivery { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ImageLogoShopUrl { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ImageCoverShopUrl { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Pin { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastedReserve { get; set; }

    public int? IsShowKTB { get; set; }

    public int? IsShowSCB { get; set; }

    public int? IsRegularLoge { get; set; }

    public int? IsActive { get; set; }

    public int? IsFood { get; set; }

    public int? IsPDPA { get; set; }

    public int? IsFood5 { get; set; }

    public int? IsGrabFood { get; set; }

    public int? IsFoodPanda { get; set; }

    public int? IsLineman { get; set; }

    public int? IsShopeeFood { get; set; }

    public int? IsGuest { get; set; }

    public int? IsGuest2 { get; set; }

    public int? Zone6 { get; set; }

    public int? isBKK { get; set; }

    public long? LastUpdateBy { get; set; }

    [InverseProperty("Member")]
    public virtual ICollection<ATKResultRecord> ATKResultRecords { get; set; } = new List<ATKResultRecord>();

    [InverseProperty("Member")]
    public virtual ICollection<AdvanceReservation> AdvanceReservations { get; set; } = new List<AdvanceReservation>();

    [InverseProperty("Member")]
    public virtual ICollection<App_MemberLinkApp> App_MemberLinkApps { get; set; } = new List<App_MemberLinkApp>();

    [InverseProperty("Member")]
    public virtual ICollection<App_MemberLoginLog> App_MemberLoginLogs { get; set; } = new List<App_MemberLoginLog>();

    [InverseProperty("Member")]
    public virtual ICollection<BlacklistMemberBooking> BlacklistMemberBookings { get; set; } = new List<BlacklistMemberBooking>();

    [InverseProperty("Member")]
    public virtual ICollection<BlacklistMember> BlacklistMembers { get; set; } = new List<BlacklistMember>();

    [InverseProperty("Member")]
    public virtual ICollection<Buddy> Buddies { get; set; } = new List<Buddy>();

    [InverseProperty("Member")]
    public virtual ICollection<BuddyCancelLog> BuddyCancelLogs { get; set; } = new List<BuddyCancelLog>();

    [InverseProperty("Member")]
    public virtual ICollection<COVID19VaccineDatum> COVID19VaccineData { get; set; } = new List<COVID19VaccineDatum>();

    [InverseProperty("Member")]
    public virtual ICollection<CheckInLog> CheckInLogs { get; set; } = new List<CheckInLog>();

    [InverseProperty("Member")]
    public virtual Covid19Healed? Covid19Healed { get; set; }

    [InverseProperty("Buyer")]
    public virtual ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();

    [InverseProperty("Member")]
    public virtual FoodHandler? FoodHandler { get; set; }

    [InverseProperty("Member")]
    public virtual ICollection<FoodShop> FoodShops { get; set; } = new List<FoodShop>();

    [InverseProperty("Member")]
    public virtual ICollection<FreshMarketVipStatusLog> FreshMarketVipStatusLogs { get; set; } = new List<FreshMarketVipStatusLog>();

    [InverseProperty("Member")]
    public virtual ICollection<FreshMarketVip> FreshMarketVips { get; set; } = new List<FreshMarketVip>();

    [InverseProperty("Member")]
    public virtual ICollection<KTBRegistration> KTBRegistrations { get; set; } = new List<KTBRegistration>();

    [InverseProperty("Member")]
    public virtual ICollection<LogeCostCustom> LogeCostCustoms { get; set; } = new List<LogeCostCustom>();

    [InverseProperty("Member")]
    public virtual ICollection<LogeEditForm> LogeEditForms { get; set; } = new List<LogeEditForm>();

    [InverseProperty("Member")]
    public virtual ICollection<MP_Member> MP_Members { get; set; } = new List<MP_Member>();

    [InverseProperty("Member")]
    public virtual ICollection<MP_Transaction> MP_Transactions { get; set; } = new List<MP_Transaction>();

    [InverseProperty("Member")]
    public virtual ICollection<MUSavingLog> MUSavingLogs { get; set; } = new List<MUSavingLog>();

    [InverseProperty("Member")]
    public virtual ICollection<MUSaving> MUSavings { get; set; } = new List<MUSaving>();

    [InverseProperty("Member")]
    public virtual ICollection<MemberActivity> MemberActivities { get; set; } = new List<MemberActivity>();

    [InverseProperty("Member")]
    public virtual ICollection<MemberCoupon> MemberCoupons { get; set; } = new List<MemberCoupon>();

    [InverseProperty("Member")]
    public virtual ICollection<MemberFood> MemberFoods { get; set; } = new List<MemberFood>();

    [InverseProperty("Member")]
    public virtual ICollection<MemberLeave> MemberLeaves { get; set; } = new List<MemberLeave>();

    [InverseProperty("Member")]
    public virtual ICollection<MemberLogeGroup> MemberLogeGroups { get; set; } = new List<MemberLogeGroup>();

    [InverseProperty("Member")]
    public virtual ICollection<MemberLog> MemberLogs { get; set; } = new List<MemberLog>();

    [InverseProperty("Member")]
    public virtual ICollection<MemberMenuList> MemberMenuListMembers { get; set; } = new List<MemberMenuList>();

    [InverseProperty("UpdateByNavigation")]
    public virtual ICollection<MemberMenuList> MemberMenuListUpdateByNavigations { get; set; } = new List<MemberMenuList>();

    [InverseProperty("Member")]
    public virtual ICollection<MemberMerchantCategory> MemberMerchantCategoryMembers { get; set; } = new List<MemberMerchantCategory>();

    [InverseProperty("UpdateByNavigation")]
    public virtual ICollection<MemberMerchantCategory> MemberMerchantCategoryUpdateByNavigations { get; set; } = new List<MemberMerchantCategory>();

    [InverseProperty("Member")]
    public virtual ICollection<MemberPointLog> MemberPointLogs { get; set; } = new List<MemberPointLog>();

    [InverseProperty("Member")]
    public virtual ICollection<MemberPoint> MemberPoints { get; set; } = new List<MemberPoint>();

    [InverseProperty("Member")]
    public virtual ICollection<MemberProductImage> MemberProductImages { get; set; } = new List<MemberProductImage>();

    [InverseProperty("Member")]
    public virtual ICollection<MemberReservationTemplate> MemberReservationTemplates { get; set; } = new List<MemberReservationTemplate>();

    [InverseProperty("Member")]
    public virtual ICollection<MemberVip> MemberVips { get; set; } = new List<MemberVip>();

    [InverseProperty("Member")]
    public virtual ICollection<Onesignal_PushNotification> Onesignal_PushNotifications { get; set; } = new List<Onesignal_PushNotification>();

    [InverseProperty("Member")]
    public virtual ICollection<PDPA_Log> PDPA_Logs { get; set; } = new List<PDPA_Log>();

    [InverseProperty("Member")]
    public virtual ICollection<QueueReservation> QueueReservations { get; set; } = new List<QueueReservation>();

    [InverseProperty("Member")]
    public virtual ICollection<QueueSMSSending> QueueSMSSendings { get; set; } = new List<QueueSMSSending>();

    [InverseProperty("Member")]
    public virtual ICollection<RegularLogePaymentLog> RegularLogePaymentLogs { get; set; } = new List<RegularLogePaymentLog>();

    [InverseProperty("Member")]
    public virtual ICollection<RegularLoge> RegularLoges { get; set; } = new List<RegularLoge>();

    [InverseProperty("Member")]
    public virtual ICollection<ReservationLogeAdditional_Backup> ReservationLogeAdditional_Backups { get; set; } = new List<ReservationLogeAdditional_Backup>();

    [InverseProperty("Member")]
    public virtual ICollection<ReservationLogeAdditional> ReservationLogeAdditionals { get; set; } = new List<ReservationLogeAdditional>();

    [InverseProperty("Member")]
    public virtual ICollection<ReservationLoge> ReservationLoges { get; set; } = new List<ReservationLoge>();

    [InverseProperty("Member")]
    public virtual ICollection<SCBRegistration> SCBRegistrations { get; set; } = new List<SCBRegistration>();

    [InverseProperty("Member")]
    public virtual ICollection<SGPointLog> SGPointLogs { get; set; } = new List<SGPointLog>();

    [InverseProperty("Member")]
    public virtual ICollection<SGSavingLog> SGSavingLogs { get; set; } = new List<SGSavingLog>();

    [InverseProperty("Member")]
    public virtual ICollection<SaveonGO_TransactionGetLogeNoPaid> SaveonGO_TransactionGetLogeNoPaids { get; set; } = new List<SaveonGO_TransactionGetLogeNoPaid>();

    [InverseProperty("Member")]
    public virtual ICollection<SaveoneGo_Blacklist> SaveoneGo_Blacklists { get; set; } = new List<SaveoneGo_Blacklist>();

    [InverseProperty("MemberId_BuddyNavigation")]
    public virtual ICollection<SaveoneGo_Buddy> SaveoneGo_BuddyMemberId_BuddyNavigations { get; set; } = new List<SaveoneGo_Buddy>();

    [InverseProperty("MemberId_HostNavigation")]
    public virtual ICollection<SaveoneGo_Buddy> SaveoneGo_BuddyMemberId_HostNavigations { get; set; } = new List<SaveoneGo_Buddy>();

    [InverseProperty("Member")]
    public virtual ICollection<SaveoneGo_CheckScoreSpecial> SaveoneGo_CheckScoreSpecials { get; set; } = new List<SaveoneGo_CheckScoreSpecial>();

    [InverseProperty("Member")]
    public virtual ICollection<SaveoneGo_CheckScore_Test> SaveoneGo_CheckScore_Tests { get; set; } = new List<SaveoneGo_CheckScore_Test>();

    [InverseProperty("Member")]
    public virtual ICollection<SaveoneGo_CheckScore> SaveoneGo_CheckScores { get; set; } = new List<SaveoneGo_CheckScore>();

    [InverseProperty("Member")]
    public virtual ICollection<SaveoneGo_Compensation> SaveoneGo_Compensations { get; set; } = new List<SaveoneGo_Compensation>();

    [InverseProperty("Member")]
    public virtual ICollection<SaveoneGo_CustomerReview> SaveoneGo_CustomerReviews { get; set; } = new List<SaveoneGo_CustomerReview>();

    [InverseProperty("Member")]
    public virtual ICollection<SaveoneGo_Fine> SaveoneGo_Fines { get; set; } = new List<SaveoneGo_Fine>();

    [InverseProperty("Member")]
    public virtual ICollection<SaveoneGo_MemberImage> SaveoneGo_MemberImages { get; set; } = new List<SaveoneGo_MemberImage>();

    [InverseProperty("Member")]
    public virtual ICollection<SaveoneGo_MemberRobinson> SaveoneGo_MemberRobinsons { get; set; } = new List<SaveoneGo_MemberRobinson>();

    [InverseProperty("Member")]
    public virtual ICollection<SaveoneGo_MemberScore_Freeze> SaveoneGo_MemberScore_Freezes { get; set; } = new List<SaveoneGo_MemberScore_Freeze>();

    [InverseProperty("Member")]
    public virtual ICollection<SaveoneGo_MemberSocialMedium> SaveoneGo_MemberSocialMedia { get; set; } = new List<SaveoneGo_MemberSocialMedium>();

    [InverseProperty("Member")]
    public virtual ICollection<SaveoneGo_MemberStamp_GetLog> SaveoneGo_MemberStamp_GetLogs { get; set; } = new List<SaveoneGo_MemberStamp_GetLog>();

    [InverseProperty("Member")]
    public virtual ICollection<SaveoneGo_MemberStamp> SaveoneGo_MemberStamps { get; set; } = new List<SaveoneGo_MemberStamp>();

    [InverseProperty("Member")]
    public virtual ICollection<SaveoneGo_Member_Privilege> SaveoneGo_Member_Privileges { get; set; } = new List<SaveoneGo_Member_Privilege>();

    [InverseProperty("Member")]
    public virtual ICollection<SaveoneGo_Member_PrivilegesLog> SaveoneGo_Member_PrivilegesLogs { get; set; } = new List<SaveoneGo_Member_PrivilegesLog>();

    [InverseProperty("Member")]
    public virtual ICollection<SaveoneGo_Member_TestScore> SaveoneGo_Member_TestScores { get; set; } = new List<SaveoneGo_Member_TestScore>();

    [InverseProperty("Member")]
    public virtual ICollection<SaveoneGo_Member> SaveoneGo_Members { get; set; } = new List<SaveoneGo_Member>();

    [InverseProperty("Member")]
    public virtual ICollection<SaveoneGo_Queue> SaveoneGo_Queues { get; set; } = new List<SaveoneGo_Queue>();

    [InverseProperty("Member")]
    public virtual ICollection<SaveoneGo_Whitelist> SaveoneGo_Whitelists { get; set; } = new List<SaveoneGo_Whitelist>();

    [InverseProperty("Member")]
    public virtual ICollection<SavingTopup> SavingTopups { get; set; } = new List<SavingTopup>();

    [InverseProperty("Member")]
    public virtual ICollection<SelectLogeFullLog> SelectLogeFullLogs { get; set; } = new List<SelectLogeFullLog>();

    [InverseProperty("Member")]
    public virtual ICollection<SmsResultLog> SmsResultLogs { get; set; } = new List<SmsResultLog>();

    [InverseProperty("Member")]
    public virtual ICollection<StallMarkerLogeLimit> StallMarkerLogeLimits { get; set; } = new List<StallMarkerLogeLimit>();

    [InverseProperty("Member")]
    public virtual ICollection<TransactionCancel> TransactionCancels { get; set; } = new List<TransactionCancel>();

    [InverseProperty("Member")]
    public virtual ICollection<Transaction_Backup> Transaction_Backups { get; set; } = new List<Transaction_Backup>();

    [InverseProperty("Member")]
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    [InverseProperty("Member")]
    public virtual ICollection<VipCondition> VipConditions { get; set; } = new List<VipCondition>();

    [InverseProperty("Member")]
    public virtual ICollection<WalletLog> WalletLogs { get; set; } = new List<WalletLog>();

    [InverseProperty("Member")]
    public virtual ICollection<Wallet> Wallets { get; set; } = new List<Wallet>();
}
