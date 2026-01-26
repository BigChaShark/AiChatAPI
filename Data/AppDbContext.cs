using System;
using System.Collections.Generic;
using AiChatAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ATKResultRecord> ATKResultRecords { get; set; }

    public virtual DbSet<Absence> Absences { get; set; }

    public virtual DbSet<Absence_Backup> Absence_Backups { get; set; }

    public virtual DbSet<AdvanceReservation> AdvanceReservations { get; set; }

    public virtual DbSet<AdvanceReservationStatus> AdvanceReservationStatuses { get; set; }

    public virtual DbSet<AppAnnounce> AppAnnounces { get; set; }

    public virtual DbSet<AppImage> AppImages { get; set; }

    public virtual DbSet<App_MemberLinkApp> App_MemberLinkApps { get; set; }

    public virtual DbSet<App_MemberLoginLog> App_MemberLoginLogs { get; set; }

    public virtual DbSet<Asset> Assets { get; set; }

    public virtual DbSet<AssetCloseFault> AssetCloseFaults { get; set; }

    public virtual DbSet<AssetFault> AssetFaults { get; set; }

    public virtual DbSet<AssetFaultLog> AssetFaultLogs { get; set; }

    public virtual DbSet<AutoRefundLog> AutoRefundLogs { get; set; }

    public virtual DbSet<AutoReservationsLog> AutoReservationsLogs { get; set; }

    public virtual DbSet<BackupProject> BackupProjects { get; set; }

    public virtual DbSet<BackupProjectLog> BackupProjectLogs { get; set; }

    public virtual DbSet<BankName> BankNames { get; set; }

    public virtual DbSet<Bank_Sattlement> Bank_Sattlements { get; set; }

    public virtual DbSet<BillVatLog> BillVatLogs { get; set; }

    public virtual DbSet<Blacklist> Blacklists { get; set; }

    public virtual DbSet<BlacklistMember> BlacklistMembers { get; set; }

    public virtual DbSet<BlacklistMemberBooking> BlacklistMemberBookings { get; set; }

    public virtual DbSet<Buddy> Buddies { get; set; }

    public virtual DbSet<BuddyCancelLog> BuddyCancelLogs { get; set; }

    public virtual DbSet<BuddyTemp> BuddyTemps { get; set; }

    public virtual DbSet<BuddyTempLog> BuddyTempLogs { get; set; }

    public virtual DbSet<BulkSMSVendor> BulkSMSVendors { get; set; }

    public virtual DbSet<BulkSMS_CallBack> BulkSMS_CallBacks { get; set; }

    public virtual DbSet<BusTrip> BusTrips { get; set; }

    public virtual DbSet<BustripLog> BustripLogs { get; set; }

    public virtual DbSet<BypassPaymentStatus> BypassPaymentStatuses { get; set; }

    public virtual DbSet<COVID19VaccineDatum> COVID19VaccineData { get; set; }

    public virtual DbSet<CancelVIP> CancelVIPs { get; set; }

    public virtual DbSet<CarMap> CarMaps { get; set; }

    public virtual DbSet<CheckInLog> CheckInLogs { get; set; }

    public virtual DbSet<CheckInLog_Backup> CheckInLog_Backups { get; set; }

    public virtual DbSet<CheckInTopupLog> CheckInTopupLogs { get; set; }

    public virtual DbSet<CheckInTopupLog_Backup> CheckInTopupLog_Backups { get; set; }

    public virtual DbSet<CheckLogeAbsence> CheckLogeAbsences { get; set; }

    public virtual DbSet<CheckLogeAbsence_Backup> CheckLogeAbsence_Backups { get; set; }

    public virtual DbSet<CheckLogeDaily> CheckLogeDailies { get; set; }

    public virtual DbSet<CheckLogeDailyLoge> CheckLogeDailyLoges { get; set; }

    public virtual DbSet<CheckLogeDaiyLogeList> CheckLogeDaiyLogeLists { get; set; }

    public virtual DbSet<CodeGen> CodeGens { get; set; }

    public virtual DbSet<Command> Commands { get; set; }

    public virtual DbSet<ContractInfo> ContractInfos { get; set; }

    public virtual DbSet<Coupon> Coupons { get; set; }

    public virtual DbSet<CouponDiscountType> CouponDiscountTypes { get; set; }

    public virtual DbSet<CouponType> CouponTypes { get; set; }

    public virtual DbSet<Covid19Healed> Covid19Healeds { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerFavouriteFoodMenu> CustomerFavouriteFoodMenus { get; set; }

    public virtual DbSet<Delivery> Deliveries { get; set; }

    public virtual DbSet<DeliveryDetail> DeliveryDetails { get; set; }

    public virtual DbSet<DeliveryTransaction> DeliveryTransactions { get; set; }

    public virtual DbSet<DeliveryTransactionDetail> DeliveryTransactionDetails { get; set; }

    public virtual DbSet<DeliveryTransactionDetailStatus> DeliveryTransactionDetailStatuses { get; set; }

    public virtual DbSet<DeliveryTransactionStatus> DeliveryTransactionStatuses { get; set; }

    public virtual DbSet<DiscountRain_PaymentGateway> DiscountRain_PaymentGateways { get; set; }

    public virtual DbSet<DiscountType> DiscountTypes { get; set; }

    public virtual DbSet<District> Districts { get; set; }

    public virtual DbSet<DummyAlgorithm> DummyAlgorithms { get; set; }

    public virtual DbSet<Dummy_Report> Dummy_Reports { get; set; }

    public virtual DbSet<ERPAllocateLoge> ERPAllocateLoges { get; set; }

    public virtual DbSet<ERPCoordinateJob> ERPCoordinateJobs { get; set; }

    public virtual DbSet<ERPCreateContract> ERPCreateContracts { get; set; }

    public virtual DbSet<ERPOperation> ERPOperations { get; set; }

    public virtual DbSet<ERPReceipt> ERPReceipts { get; set; }

    public virtual DbSet<ERPSurveyRequirement> ERPSurveyRequirements { get; set; }

    public virtual DbSet<ERPTransaction> ERPTransactions { get; set; }

    public virtual DbSet<EStamp> EStamps { get; set; }

    public virtual DbSet<EditContract> EditContracts { get; set; }

    public virtual DbSet<ExchangeEStampPerLogeRate> ExchangeEStampPerLogeRates { get; set; }

    public virtual DbSet<FavouriteShop> FavouriteShops { get; set; }

    public virtual DbSet<Fine> Fines { get; set; }

    public virtual DbSet<FineType> FineTypes { get; set; }

    public virtual DbSet<FoodCategory> FoodCategories { get; set; }

    public virtual DbSet<FoodHandler> FoodHandlers { get; set; }

    public virtual DbSet<FoodMenu> FoodMenus { get; set; }

    public virtual DbSet<FoodMenuAddOn> FoodMenuAddOns { get; set; }

    public virtual DbSet<FoodMenuAddOnDetail> FoodMenuAddOnDetails { get; set; }

    public virtual DbSet<FoodMenuCategory> FoodMenuCategories { get; set; }

    public virtual DbSet<FoodMenuCustom> FoodMenuCustoms { get; set; }

    public virtual DbSet<FoodMenuFlashSale> FoodMenuFlashSales { get; set; }

    public virtual DbSet<FoodPickUpSenderDate> FoodPickUpSenderDates { get; set; }

    public virtual DbSet<FoodSender> FoodSenders { get; set; }

    public virtual DbSet<FoodShop> FoodShops { get; set; }

    public virtual DbSet<FoodShopOpenDay> FoodShopOpenDays { get; set; }

    public virtual DbSet<FoodTransaction> FoodTransactions { get; set; }

    public virtual DbSet<FoodTransactionAlertConfiguration> FoodTransactionAlertConfigurations { get; set; }

    public virtual DbSet<FoodTransactionAlliance> FoodTransactionAlliances { get; set; }

    public virtual DbSet<FoodTransactionCode> FoodTransactionCodes { get; set; }

    public virtual DbSet<FoodTransactionCustomerActivity> FoodTransactionCustomerActivities { get; set; }

    public virtual DbSet<FoodTransactionCustomerEventLog> FoodTransactionCustomerEventLogs { get; set; }

    public virtual DbSet<FoodTransactionCustomerNotFound> FoodTransactionCustomerNotFounds { get; set; }

    public virtual DbSet<FoodTransactionDetail> FoodTransactionDetails { get; set; }

    public virtual DbSet<FoodTransactionDetailAddOn> FoodTransactionDetailAddOns { get; set; }

    public virtual DbSet<FoodTransactionImage> FoodTransactionImages { get; set; }

    public virtual DbSet<FoodTransactionLog> FoodTransactionLogs { get; set; }

    public virtual DbSet<FoodTransactionMerchantDiscount> FoodTransactionMerchantDiscounts { get; set; }

    public virtual DbSet<FoodTransactionPickUpLog> FoodTransactionPickUpLogs { get; set; }

    public virtual DbSet<FoodTransactionStaffDiscount> FoodTransactionStaffDiscounts { get; set; }

    public virtual DbSet<FoodTransactionStatus> FoodTransactionStatuses { get; set; }

    public virtual DbSet<FoodType> FoodTypes { get; set; }

    public virtual DbSet<FoodWalker> FoodWalkers { get; set; }

    public virtual DbSet<FoodWalkerDayOff> FoodWalkerDayOffs { get; set; }

    public virtual DbSet<FoodtransactionDetailCancel> FoodtransactionDetailCancels { get; set; }

    public virtual DbSet<FreeDay> FreeDays { get; set; }

    public virtual DbSet<FreshMarketCouponConfirm> FreshMarketCouponConfirms { get; set; }

    public virtual DbSet<FreshMarketMemo> FreshMarketMemos { get; set; }

    public virtual DbSet<FreshMarketReservationLoge> FreshMarketReservationLoges { get; set; }

    public virtual DbSet<FreshMarketTransaction> FreshMarketTransactions { get; set; }

    public virtual DbSet<FreshMarketVip> FreshMarketVips { get; set; }

    public virtual DbSet<FreshMarketVipAddByAdmin> FreshMarketVipAddByAdmins { get; set; }

    public virtual DbSet<FreshMarketVipCountErrorLog> FreshMarketVipCountErrorLogs { get; set; }

    public virtual DbSet<FreshMarketVipStatusLog> FreshMarketVipStatusLogs { get; set; }

    public virtual DbSet<GetEStampLogeRate> GetEStampLogeRates { get; set; }

    public virtual DbSet<ImageShow> ImageShows { get; set; }

    public virtual DbSet<ImpDatum> ImpData { get; set; }

    public virtual DbSet<IncorrectDataSMSLog> IncorrectDataSMSLogs { get; set; }

    public virtual DbSet<KTBRegistration> KTBRegistrations { get; set; }

    public virtual DbSet<KitchenWallet> KitchenWallets { get; set; }

    public virtual DbSet<KitchenWalletLog> KitchenWalletLogs { get; set; }

    public virtual DbSet<KitchenWalletType> KitchenWalletTypes { get; set; }

    public virtual DbSet<LandingPageBanner> LandingPageBanners { get; set; }

    public virtual DbSet<LineApiLog> LineApiLogs { get; set; }

    public virtual DbSet<LineApiType> LineApiTypes { get; set; }

    public virtual DbSet<LineTokenGroup> LineTokenGroups { get; set; }

    public virtual DbSet<Line_NotificationLog> Line_NotificationLogs { get; set; }

    public virtual DbSet<LockerMember> LockerMembers { get; set; }

    public virtual DbSet<Loge> Loges { get; set; }

    public virtual DbSet<LogeCost> LogeCosts { get; set; }

    public virtual DbSet<LogeCostByType> LogeCostByTypes { get; set; }

    public virtual DbSet<LogeCostCustom> LogeCostCustoms { get; set; }

    public virtual DbSet<LogeCostMX> LogeCostMXes { get; set; }

    public virtual DbSet<LogeCostPerDay> LogeCostPerDays { get; set; }

    public virtual DbSet<LogeCostZoneCustom> LogeCostZoneCustoms { get; set; }

    public virtual DbSet<LogeEditForm> LogeEditForms { get; set; }

    public virtual DbSet<LogeGroup> LogeGroups { get; set; }

    public virtual DbSet<LogeGroupOpenDate> LogeGroupOpenDates { get; set; }

    public virtual DbSet<LogeLocation> LogeLocations { get; set; }

    public virtual DbSet<LogeLocationTemp> LogeLocationTemps { get; set; }

    public virtual DbSet<LogeMapping> LogeMappings { get; set; }

    public virtual DbSet<LogeReturnForm> LogeReturnForms { get; set; }

    public virtual DbSet<LogeTemp> LogeTemps { get; set; }

    public virtual DbSet<LogeTemp_Backup> LogeTemp_Backups { get; set; }

    public virtual DbSet<LogeTemp_Master> LogeTemp_Masters { get; set; }

    public virtual DbSet<LogeTemp_Offline> LogeTemp_Offlines { get; set; }

    public virtual DbSet<LogeType> LogeTypes { get; set; }

    public virtual DbSet<LogicWorkLog> LogicWorkLogs { get; set; }

    public virtual DbSet<LogicWorkLog_Backup> LogicWorkLog_Backups { get; set; }

    public virtual DbSet<LowerLogeLog> LowerLogeLogs { get; set; }

    public virtual DbSet<MP_Member> MP_Members { get; set; }

    public virtual DbSet<MP_Service> MP_Services { get; set; }

    public virtual DbSet<MP_Transaction> MP_Transactions { get; set; }

    public virtual DbSet<MP_TransactionStatus> MP_TransactionStatuses { get; set; }

    public virtual DbSet<MP_Transaction_Backup> MP_Transaction_Backups { get; set; }

    public virtual DbSet<MUSaving> MUSavings { get; set; }

    public virtual DbSet<MUSavingBalanceMonthly> MUSavingBalanceMonthlies { get; set; }

    public virtual DbSet<MUSavingLog> MUSavingLogs { get; set; }

    public virtual DbSet<MUSavingLogType> MUSavingLogTypes { get; set; }

    public virtual DbSet<MUSavingLog_Backup> MUSavingLog_Backups { get; set; }

    public virtual DbSet<MajorCustomerInfo> MajorCustomerInfos { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<MemberActivity> MemberActivities { get; set; }

    public virtual DbSet<MemberCoupon> MemberCoupons { get; set; }

    public virtual DbSet<MemberFood> MemberFoods { get; set; }

    public virtual DbSet<MemberFoodCustom> MemberFoodCustoms { get; set; }

    public virtual DbSet<MemberLeave> MemberLeaves { get; set; }

    public virtual DbSet<MemberLeave_Backup> MemberLeave_Backups { get; set; }

    public virtual DbSet<MemberLocationLogin> MemberLocationLogins { get; set; }

    public virtual DbSet<MemberLog> MemberLogs { get; set; }

    public virtual DbSet<MemberLogeGroup> MemberLogeGroups { get; set; }

    public virtual DbSet<MemberMenuList> MemberMenuLists { get; set; }

    public virtual DbSet<MemberMerchantCategory> MemberMerchantCategories { get; set; }

    public virtual DbSet<MemberPoint> MemberPoints { get; set; }

    public virtual DbSet<MemberPointBalanceMonthly> MemberPointBalanceMonthlies { get; set; }

    public virtual DbSet<MemberPointLog> MemberPointLogs { get; set; }

    public virtual DbSet<MemberPointLogType> MemberPointLogTypes { get; set; }

    public virtual DbSet<MemberProductImage> MemberProductImages { get; set; }

    public virtual DbSet<MemberRefKey> MemberRefKeys { get; set; }

    public virtual DbSet<MemberReservationTemplate> MemberReservationTemplates { get; set; }

    public virtual DbSet<MemberStatisticRanking> MemberStatisticRankings { get; set; }

    public virtual DbSet<MemberTemp> MemberTemps { get; set; }

    public virtual DbSet<MemberTempLog> MemberTempLogs { get; set; }

    public virtual DbSet<MemberVip> MemberVips { get; set; }

    public virtual DbSet<MenuCategory> MenuCategories { get; set; }

    public virtual DbSet<Merchant> Merchants { get; set; }

    public virtual DbSet<MerchantCategory> MerchantCategories { get; set; }

    public virtual DbSet<MessengerChat> MessengerChats { get; set; }

    public virtual DbSet<MessengerFlashSale> MessengerFlashSales { get; set; }

    public virtual DbSet<MoneyFlow> MoneyFlows { get; set; }

    public virtual DbSet<MonthlyMemberLoge> MonthlyMemberLoges { get; set; }

    public virtual DbSet<NativeApp_Notification> NativeApp_Notifications { get; set; }

    public virtual DbSet<NativeApp_Token> NativeApp_Tokens { get; set; }

    public virtual DbSet<OTPLog> OTPLogs { get; set; }

    public virtual DbSet<OnesignalLog> OnesignalLogs { get; set; }

    public virtual DbSet<Onesignal_PushNotification> Onesignal_PushNotifications { get; set; }

    public virtual DbSet<OpenTimeZone> OpenTimeZones { get; set; }

    public virtual DbSet<OutStanding> OutStandings { get; set; }

    public virtual DbSet<OutStandingDebtLog> OutStandingDebtLogs { get; set; }

    public virtual DbSet<OutstandingDebt> OutstandingDebts { get; set; }

    public virtual DbSet<PDPA_Log> PDPA_Logs { get; set; }

    public virtual DbSet<PayPadLoge> PayPadLoges { get; set; }

    public virtual DbSet<Payin> Payins { get; set; }

    public virtual DbSet<PaymentGateway> PaymentGateways { get; set; }

    public virtual DbSet<PaymentGatewayMethod> PaymentGatewayMethods { get; set; }

    public virtual DbSet<PaymentLog> PaymentLogs { get; set; }

    public virtual DbSet<PaymentLog_Backup> PaymentLog_Backups { get; set; }

    public virtual DbSet<PaymentOverWallet> PaymentOverWallets { get; set; }

    public virtual DbSet<PaymentType> PaymentTypes { get; set; }

    public virtual DbSet<PermitsAccessArea> PermitsAccessAreas { get; set; }

    public virtual DbSet<PostTransaction> PostTransactions { get; set; }

    public virtual DbSet<PostTransactionDetail> PostTransactionDetails { get; set; }

    public virtual DbSet<PostTransactionPostType> PostTransactionPostTypes { get; set; }

    public virtual DbSet<PostTransactionStatus> PostTransactionStatuses { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<ProductModel> ProductModels { get; set; }

    public virtual DbSet<Province> Provinces { get; set; }

    public virtual DbSet<QueueReservation> QueueReservations { get; set; }

    public virtual DbSet<QueueRound> QueueRounds { get; set; }

    public virtual DbSet<QueueSMSSending> QueueSMSSendings { get; set; }

    public virtual DbSet<QueueSMSSending_Backup> QueueSMSSending_Backups { get; set; }

    public virtual DbSet<ReceiptIndex> ReceiptIndices { get; set; }

    public virtual DbSet<ReceiptLog> ReceiptLogs { get; set; }

    public virtual DbSet<ReceiptType> ReceiptTypes { get; set; }

    public virtual DbSet<RecommendFoodCategory> RecommendFoodCategories { get; set; }

    public virtual DbSet<RegularLoge> RegularLoges { get; set; }

    public virtual DbSet<RegularLogeElectricType> RegularLogeElectricTypes { get; set; }

    public virtual DbSet<RegularLogeExcel> RegularLogeExcels { get; set; }

    public virtual DbSet<RegularLogePaymentLog> RegularLogePaymentLogs { get; set; }

    public virtual DbSet<RegularLogePaymentType> RegularLogePaymentTypes { get; set; }

    public virtual DbSet<RegularLogeType> RegularLogeTypes { get; set; }

    public virtual DbSet<RegularLogeWaterType> RegularLogeWaterTypes { get; set; }

    public virtual DbSet<RegularLogeZone> RegularLogeZones { get; set; }

    public virtual DbSet<RegularLoge_Invoice> RegularLoge_Invoices { get; set; }

    public virtual DbSet<RegularLoge_InvoiceStatus> RegularLoge_InvoiceStatuses { get; set; }

    public virtual DbSet<RegularLoge_TransactionStatus> RegularLoge_TransactionStatuses { get; set; }

    public virtual DbSet<ReportPaymentGatewayRemark> ReportPaymentGatewayRemarks { get; set; }

    public virtual DbSet<ReprintLog> ReprintLogs { get; set; }

    public virtual DbSet<ReprintType> ReprintTypes { get; set; }

    public virtual DbSet<ReservationLoge> ReservationLoges { get; set; }

    public virtual DbSet<ReservationLogeAdditional> ReservationLogeAdditionals { get; set; }

    public virtual DbSet<ReservationLogeAdditional_Backup> ReservationLogeAdditional_Backups { get; set; }

    public virtual DbSet<ReservationLogeDetail> ReservationLogeDetails { get; set; }

    public virtual DbSet<ReservationLogeDetail_Backup> ReservationLogeDetail_Backups { get; set; }

    public virtual DbSet<ReservationLogeElectricityType> ReservationLogeElectricityTypes { get; set; }

    public virtual DbSet<ReservationLogeElectronicType> ReservationLogeElectronicTypes { get; set; }

    public virtual DbSet<ReservationLogeLastGroupSeqNo> ReservationLogeLastGroupSeqNos { get; set; }

    public virtual DbSet<ReservationLogeLimit> ReservationLogeLimits { get; set; }

    public virtual DbSet<ReservationLogeLimitLog> ReservationLogeLimitLogs { get; set; }

    public virtual DbSet<ReservationLogeMx> ReservationLogeMxes { get; set; }

    public virtual DbSet<ReservationLogeMx_Backup> ReservationLogeMx_Backups { get; set; }

    public virtual DbSet<ReservationLogeType> ReservationLogeTypes { get; set; }

    public virtual DbSet<ReservationLoge_Backup> ReservationLoge_Backups { get; set; }

    public virtual DbSet<Right> Rights { get; set; }

    public virtual DbSet<SCBQrcodePayment> SCBQrcodePayments { get; set; }

    public virtual DbSet<SCBQrcodePayment_Backup> SCBQrcodePayment_Backups { get; set; }

    public virtual DbSet<SCBRegistration> SCBRegistrations { get; set; }

    public virtual DbSet<SCB_PaymentConfirmation> SCB_PaymentConfirmations { get; set; }

    public virtual DbSet<SGDiscount> SGDiscounts { get; set; }

    public virtual DbSet<SGPoint> SGPoints { get; set; }

    public virtual DbSet<SGPointLog> SGPointLogs { get; set; }

    public virtual DbSet<SGPointLogType> SGPointLogTypes { get; set; }

    public virtual DbSet<SGPromotion> SGPromotions { get; set; }

    public virtual DbSet<SGPromotionType> SGPromotionTypes { get; set; }

    public virtual DbSet<SGPromotion_Target> SGPromotion_Targets { get; set; }

    public virtual DbSet<SGPromotion_ZoneMarket> SGPromotion_ZoneMarkets { get; set; }

    public virtual DbSet<SGSaving> SGSavings { get; set; }

    public virtual DbSet<SGSavingLog> SGSavingLogs { get; set; }

    public virtual DbSet<SGSavingLogType> SGSavingLogTypes { get; set; }

    public virtual DbSet<SGSavingLogs_Backup> SGSavingLogs_Backups { get; set; }

    public virtual DbSet<SMSLog> SMSLogs { get; set; }

    public virtual DbSet<SMSToMobile> SMSToMobiles { get; set; }

    public virtual DbSet<SaveonGO_TransactionGetLogeNoPaid> SaveonGO_TransactionGetLogeNoPaids { get; set; }

    public virtual DbSet<SaveonGO_TransactionGetLogeNoPaid_Backup> SaveonGO_TransactionGetLogeNoPaid_Backups { get; set; }

    public virtual DbSet<SaveoneBuse> SaveoneBuses { get; set; }

    public virtual DbSet<SaveoneCallback> SaveoneCallbacks { get; set; }

    public virtual DbSet<SaveoneGo_BanlistType> SaveoneGo_BanlistTypes { get; set; }

    public virtual DbSet<SaveoneGo_Blacklist> SaveoneGo_Blacklists { get; set; }

    public virtual DbSet<SaveoneGo_Blacklist_Backup> SaveoneGo_Blacklist_Backups { get; set; }

    public virtual DbSet<SaveoneGo_Buddy> SaveoneGo_Buddies { get; set; }

    public virtual DbSet<SaveoneGo_BuddyCancel> SaveoneGo_BuddyCancels { get; set; }

    public virtual DbSet<SaveoneGo_BuddyStatus> SaveoneGo_BuddyStatuses { get; set; }

    public virtual DbSet<SaveoneGo_Buddy_Log> SaveoneGo_Buddy_Logs { get; set; }

    public virtual DbSet<SaveoneGo_CheckScore> SaveoneGo_CheckScores { get; set; }

    public virtual DbSet<SaveoneGo_CheckScoreDetail> SaveoneGo_CheckScoreDetails { get; set; }

    public virtual DbSet<SaveoneGo_CheckScoreDetail_Backup> SaveoneGo_CheckScoreDetail_Backups { get; set; }

    public virtual DbSet<SaveoneGo_CheckScoreDetail_Test> SaveoneGo_CheckScoreDetail_Tests { get; set; }

    public virtual DbSet<SaveoneGo_CheckScoreSpecial> SaveoneGo_CheckScoreSpecials { get; set; }

    public virtual DbSet<SaveoneGo_CheckScoreSpecial_Backup> SaveoneGo_CheckScoreSpecial_Backups { get; set; }

    public virtual DbSet<SaveoneGo_CheckScoreTopic> SaveoneGo_CheckScoreTopics { get; set; }

    public virtual DbSet<SaveoneGo_CheckScoreTopicList> SaveoneGo_CheckScoreTopicLists { get; set; }

    public virtual DbSet<SaveoneGo_CheckScore_Backup> SaveoneGo_CheckScore_Backups { get; set; }

    public virtual DbSet<SaveoneGo_CheckScore_Test> SaveoneGo_CheckScore_Tests { get; set; }

    public virtual DbSet<SaveoneGo_Compensation> SaveoneGo_Compensations { get; set; }

    public virtual DbSet<SaveoneGo_CompensationType> SaveoneGo_CompensationTypes { get; set; }

    public virtual DbSet<SaveoneGo_Customer> SaveoneGo_Customers { get; set; }

    public virtual DbSet<SaveoneGo_CustomerReview> SaveoneGo_CustomerReviews { get; set; }

    public virtual DbSet<SaveoneGo_CustomerReviewImage> SaveoneGo_CustomerReviewImages { get; set; }

    public virtual DbSet<SaveoneGo_CustomerReviewList> SaveoneGo_CustomerReviewLists { get; set; }

    public virtual DbSet<SaveoneGo_CustomerReviewQuestion> SaveoneGo_CustomerReviewQuestions { get; set; }

    public virtual DbSet<SaveoneGo_Fine> SaveoneGo_Fines { get; set; }

    public virtual DbSet<SaveoneGo_FineStatus> SaveoneGo_FineStatuses { get; set; }

    public virtual DbSet<SaveoneGo_Fine_Backup> SaveoneGo_Fine_Backups { get; set; }

    public virtual DbSet<SaveoneGo_FleaMarketShopType> SaveoneGo_FleaMarketShopTypes { get; set; }

    public virtual DbSet<SaveoneGo_Market> SaveoneGo_Markets { get; set; }

    public virtual DbSet<SaveoneGo_Member> SaveoneGo_Members { get; set; }

    public virtual DbSet<SaveoneGo_MemberImage> SaveoneGo_MemberImages { get; set; }

    public virtual DbSet<SaveoneGo_MemberPrivilege> SaveoneGo_MemberPrivileges { get; set; }

    public virtual DbSet<SaveoneGo_MemberRobinson> SaveoneGo_MemberRobinsons { get; set; }

    public virtual DbSet<SaveoneGo_MemberScore_Freeze> SaveoneGo_MemberScore_Freezes { get; set; }

    public virtual DbSet<SaveoneGo_MemberSocialMedium> SaveoneGo_MemberSocialMedia { get; set; }

    public virtual DbSet<SaveoneGo_MemberStamp> SaveoneGo_MemberStamps { get; set; }

    public virtual DbSet<SaveoneGo_MemberStampStatus> SaveoneGo_MemberStampStatuses { get; set; }

    public virtual DbSet<SaveoneGo_MemberStamp_GetLog> SaveoneGo_MemberStamp_GetLogs { get; set; }

    public virtual DbSet<SaveoneGo_Member_FleaMarket> SaveoneGo_Member_FleaMarkets { get; set; }

    public virtual DbSet<SaveoneGo_Member_Privilege> SaveoneGo_Member_Privileges { get; set; }

    public virtual DbSet<SaveoneGo_Member_PrivilegesLog> SaveoneGo_Member_PrivilegesLogs { get; set; }

    public virtual DbSet<SaveoneGo_Member_TestScore> SaveoneGo_Member_TestScores { get; set; }

    public virtual DbSet<SaveoneGo_Queue> SaveoneGo_Queues { get; set; }

    public virtual DbSet<SaveoneGo_QueueStatus> SaveoneGo_QueueStatuses { get; set; }

    public virtual DbSet<SaveoneGo_Ranking> SaveoneGo_Rankings { get; set; }

    public virtual DbSet<SaveoneGo_Ranking_Log> SaveoneGo_Ranking_Logs { get; set; }

    public virtual DbSet<SaveoneGo_Starscore> SaveoneGo_Starscores { get; set; }

    public virtual DbSet<SaveoneGo_WeeklyRanking> SaveoneGo_WeeklyRankings { get; set; }

    public virtual DbSet<SaveoneGo_Whitelist> SaveoneGo_Whitelists { get; set; }

    public virtual DbSet<SaveoneGo_ZoneMarket> SaveoneGo_ZoneMarkets { get; set; }

    public virtual DbSet<SaveoneGo_Zone_SubZone> SaveoneGo_Zone_SubZones { get; set; }

    public virtual DbSet<SavingBalanceLog> SavingBalanceLogs { get; set; }

    public virtual DbSet<SavingReceive> SavingReceives { get; set; }

    public virtual DbSet<SavingReceive2> SavingReceive2s { get; set; }

    public virtual DbSet<SavingReceive_Backup> SavingReceive_Backups { get; set; }

    public virtual DbSet<SavingTopup> SavingTopups { get; set; }

    public virtual DbSet<SelectLogeFullLog> SelectLogeFullLogs { get; set; }

    public virtual DbSet<Settlement> Settlements { get; set; }

    public virtual DbSet<ShopType> ShopTypes { get; set; }

    public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }

    public virtual DbSet<ShoppingCartDetail> ShoppingCartDetails { get; set; }

    public virtual DbSet<ShoppingCartStatus> ShoppingCartStatuses { get; set; }

    public virtual DbSet<SkipOTP> SkipOTPs { get; set; }

    public virtual DbSet<SmsLogeFullLog> SmsLogeFullLogs { get; set; }

    public virtual DbSet<SmsReservationLog> SmsReservationLogs { get; set; }

    public virtual DbSet<SmsResultLog> SmsResultLogs { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<StaffLoginLocationLog> StaffLoginLocationLogs { get; set; }

    public virtual DbSet<StaffUser> StaffUsers { get; set; }

    public virtual DbSet<StaffUserRight> StaffUserRights { get; set; }

    public virtual DbSet<StallMarkerLogeLimit> StallMarkerLogeLimits { get; set; }

    public virtual DbSet<StallMarketVIP2> StallMarketVIP2s { get; set; }

    public virtual DbSet<StallMarketVip> StallMarketVips { get; set; }

    public virtual DbSet<StatisticType> StatisticTypes { get; set; }

    public virtual DbSet<SubZone> SubZones { get; set; }

    public virtual DbSet<SurveyMember> SurveyMembers { get; set; }

    public virtual DbSet<TaskSchedulerLog> TaskSchedulerLogs { get; set; }

    public virtual DbSet<TempCustomer> TempCustomers { get; set; }

    public virtual DbSet<TempLockerAmount> TempLockerAmounts { get; set; }

    public virtual DbSet<TempMP> TempMPs { get; set; }

    public virtual DbSet<TempMU> TempMUs { get; set; }

    public virtual DbSet<TempSM> TempSMs { get; set; }

    public virtual DbSet<TempWallet> TempWallets { get; set; }

    public virtual DbSet<TemporaryFoodMenu> TemporaryFoodMenus { get; set; }

    public virtual DbSet<TemporaryFoodMenuAddOn> TemporaryFoodMenuAddOns { get; set; }

    public virtual DbSet<TemporaryFoodMenuAddOnDetail> TemporaryFoodMenuAddOnDetails { get; set; }

    public virtual DbSet<TemporaryFoodMenuLog> TemporaryFoodMenuLogs { get; set; }

    public virtual DbSet<TemporaryFoodShop> TemporaryFoodShops { get; set; }

    public virtual DbSet<TemporaryFoodShopOpenDay> TemporaryFoodShopOpenDays { get; set; }

    public virtual DbSet<TemporaryFoodShopStatus> TemporaryFoodShopStatuses { get; set; }

    public virtual DbSet<ThaiBulkSMS_CallBack> ThaiBulkSMS_CallBacks { get; set; }

    public virtual DbSet<ToiletCloseFault> ToiletCloseFaults { get; set; }

    public virtual DbSet<ToiletEquipment> ToiletEquipments { get; set; }

    public virtual DbSet<ToiletFault> ToiletFaults { get; set; }

    public virtual DbSet<ToiletFaultEmployee> ToiletFaultEmployees { get; set; }

    public virtual DbSet<ToiletFaultLog> ToiletFaultLogs { get; set; }

    public virtual DbSet<ToiletFaultPickingList> ToiletFaultPickingLists { get; set; }

    public virtual DbSet<ToiletType> ToiletTypes { get; set; }

    public virtual DbSet<ToiletZone> ToiletZones { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<TransactionCancel> TransactionCancels { get; set; }

    public virtual DbSet<TransactionCancel_Backup> TransactionCancel_Backups { get; set; }

    public virtual DbSet<TransactionDetail> TransactionDetails { get; set; }

    public virtual DbSet<TransactionDetail_Backup> TransactionDetail_Backups { get; set; }

    public virtual DbSet<TransactionDiscount> TransactionDiscounts { get; set; }

    public virtual DbSet<TransactionRefund> TransactionRefunds { get; set; }

    public virtual DbSet<TransactionSGPromotion> TransactionSGPromotions { get; set; }

    public virtual DbSet<TransactionStaff> TransactionStaffs { get; set; }

    public virtual DbSet<TransactionStatus> TransactionStatuses { get; set; }

    public virtual DbSet<TransactionTaxRcpt> TransactionTaxRcpts { get; set; }

    public virtual DbSet<TransactionTaxRcpts_Backup> TransactionTaxRcpts_Backups { get; set; }

    public virtual DbSet<TransactionTaxRcpts_Backup2> TransactionTaxRcpts_Backup2s { get; set; }

    public virtual DbSet<TransactionTaxReceiptSet> TransactionTaxReceiptSets { get; set; }

    public virtual DbSet<TransactionType> TransactionTypes { get; set; }

    public virtual DbSet<Transaction_Backup> Transaction_Backups { get; set; }

    public virtual DbSet<UserLevel> UserLevels { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<UserRoleRight> UserRoleRights { get; set; }

    public virtual DbSet<User_Offline> User_Offlines { get; set; }

    public virtual DbSet<V3_> V3_s { get; set; }

    public virtual DbSet<V4_> V4_s { get; set; }

    public virtual DbSet<V5_> V5_s { get; set; }

    public virtual DbSet<V6_> V6_s { get; set; }

    public virtual DbSet<V7_> V7_s { get; set; }

    public virtual DbSet<VFleaMarket_> VFleaMarket_s { get; set; }

    public virtual DbSet<Valve> Valves { get; set; }

    public virtual DbSet<ValveLog> ValveLogs { get; set; }

    public virtual DbSet<ValveMember> ValveMembers { get; set; }

    public virtual DbSet<VatReportRun> VatReportRuns { get; set; }

    public virtual DbSet<View_1> View_1s { get; set; }

    public virtual DbSet<View_MUSavingBalanceMonthly> View_MUSavingBalanceMonthlies { get; set; }

    public virtual DbSet<View_MUSavingBalanceMonthly_ALL> View_MUSavingBalanceMonthly_ALLs { get; set; }

    public virtual DbSet<View_MemberPointBalanceMonthly> View_MemberPointBalanceMonthlies { get; set; }

    public virtual DbSet<View_WalletBalanceMonthly> View_WalletBalanceMonthlies { get; set; }

    public virtual DbSet<View_WalletBalanceMonthly_ALL> View_WalletBalanceMonthly_ALLs { get; set; }

    public virtual DbSet<View_WalletLog_Union_WalletLogBackup> View_WalletLog_Union_WalletLogBackups { get; set; }

    public virtual DbSet<View_ตรวจสอบ_ReturnError555> View_ตรวจสอบ_ReturnError555s { get; set; }

    public virtual DbSet<VipCondition> VipConditions { get; set; }

    public virtual DbSet<VipSetting> VipSettings { get; set; }

    public virtual DbSet<VisibleButton_Seller> VisibleButton_Sellers { get; set; }

    public virtual DbSet<VisibleZonePrice> VisibleZonePrices { get; set; }

    public virtual DbSet<Vm_> Vm_s { get; set; }

    public virtual DbSet<WalkerAbsence> WalkerAbsences { get; set; }

    public virtual DbSet<WalkerCashLog> WalkerCashLogs { get; set; }

    public virtual DbSet<WalkerCheckIn> WalkerCheckIns { get; set; }

    public virtual DbSet<Wallet> Wallets { get; set; }

    public virtual DbSet<WalletBalanceMonthly> WalletBalanceMonthlies { get; set; }

    public virtual DbSet<WalletLog> WalletLogs { get; set; }

    public virtual DbSet<WalletLogType> WalletLogTypes { get; set; }

    public virtual DbSet<WalletLog_Backup> WalletLog_Backups { get; set; }

    public virtual DbSet<WebAdminLog> WebAdminLogs { get; set; }

    public virtual DbSet<Zone> Zones { get; set; }

    public virtual DbSet<ZoneMember> ZoneMembers { get; set; }

    public virtual DbSet<saveonGO_TransactionReturn> saveonGO_TransactionReturns { get; set; }

    public virtual DbSet<saveonGO_TransactionReturn_Backup> saveonGO_TransactionReturn_Backups { get; set; }

    public virtual DbSet<ข้อมูล_> ข้อมูล_s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Thai_CI_AS");

        modelBuilder.Entity<ATKResultRecord>(entity =>
        {
            entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Member).WithMany(p => p.ATKResultRecords)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ATKResultRecord_Member");

            entity.HasOne(d => d.StaffUser).WithMany(p => p.ATKResultRecordStaffUsers).HasConstraintName("FK_ATKResultRecord_StaffUser");

            entity.HasOne(d => d.UpdateStaffUser).WithMany(p => p.ATKResultRecordUpdateStaffUsers).HasConstraintName("FK_ATKResultRecord_StaffUser1");
        });

        modelBuilder.Entity<Absence>(entity =>
        {
            entity.HasOne(d => d.Transaction).WithMany(p => p.Absences).HasConstraintName("FK_Absence_Transaction");
        });

        modelBuilder.Entity<Absence_Backup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<AdvanceReservation>(entity =>
        {
            entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.LastUpdate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Member).WithMany(p => p.AdvanceReservations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdvanceReservation_Member");

            entity.HasOne(d => d.PaymentType).WithMany(p => p.AdvanceReservations).HasConstraintName("FK_AdvanceReservation_PaymentType");

            entity.HasOne(d => d.ReservationLogeElectricityType).WithMany(p => p.AdvanceReservations).HasConstraintName("FK_AdvanceReservation_ReservationLogeElectricityType");

            entity.HasOne(d => d.ReservationLogeElectronicType).WithMany(p => p.AdvanceReservations).HasConstraintName("FK_AdvanceReservation_ReservationLogeElectronicType");

            entity.HasOne(d => d.ReservationLogeType).WithMany(p => p.AdvanceReservations).HasConstraintName("FK_AdvanceReservation_ReservationLogeType");

            entity.HasOne(d => d.StaffUser).WithMany(p => p.AdvanceReservations).HasConstraintName("FK_AdvanceReservation_StaffUser");

            entity.HasOne(d => d.SubZone).WithMany(p => p.AdvanceReservations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdvanceReservation_SubZone");
        });

        modelBuilder.Entity<AdvanceReservationStatus>(entity =>
        {
            entity.Property(e => e.ZoneId).ValueGeneratedNever();

            entity.HasOne(d => d.StaffUser).WithMany(p => p.AdvanceReservationStatuses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdvanceReservationStatus_StaffUser");

            entity.HasOne(d => d.Zone).WithOne(p => p.AdvanceReservationStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdvanceReservationStatus_Zone");
        });

        modelBuilder.Entity<AppAnnounce>(entity =>
        {
            entity.HasOne(d => d.StaffUser).WithMany(p => p.AppAnnounces).HasConstraintName("FK_AppAnnounce_StaffUser");
        });

        modelBuilder.Entity<AppImage>(entity =>
        {
            entity.HasOne(d => d.UpdateByNavigation).WithMany(p => p.AppImages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AppImage_StaffUser");
        });

        modelBuilder.Entity<App_MemberLinkApp>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.App_MemberLinkApps)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_App_MemberLinkApp");
        });

        modelBuilder.Entity<App_MemberLoginLog>(entity =>
        {
            entity.HasOne(d => d.App_MemberLinkApp).WithMany(p => p.App_MemberLoginLogs)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_App_MemberLoginLog_App_MemberLinkApp");

            entity.HasOne(d => d.Member).WithMany(p => p.App_MemberLoginLogs).HasConstraintName("FK_App_MemberLoginLog_Member");
        });

        modelBuilder.Entity<AssetCloseFault>(entity =>
        {
            entity.HasOne(d => d.AssetFault).WithMany(p => p.AssetCloseFaults).HasConstraintName("FK_AssetCloseFaults_AssetFaults");
        });

        modelBuilder.Entity<AssetFault>(entity =>
        {
            entity.HasOne(d => d.Asset).WithMany(p => p.AssetFaults).HasConstraintName("FK_AssetFaults_Assets");
        });

        modelBuilder.Entity<AssetFaultLog>(entity =>
        {
            entity.HasOne(d => d.AssetFault).WithMany(p => p.AssetFaultLogs).HasConstraintName("FK_AssetFaultLogs_AssetFaults");
        });

        modelBuilder.Entity<AutoReservationsLog>(entity =>
        {
            entity.HasOne(d => d.SubZone).WithMany(p => p.AutoReservationsLogs).HasConstraintName("FK_AutoReservationsLog_SubZone");
        });

        modelBuilder.Entity<BackupProject>(entity =>
        {
            entity.Property(e => e.Status).IsFixedLength();
        });

        modelBuilder.Entity<BackupProjectLog>(entity =>
        {
            entity.Property(e => e.IsSuccess).IsFixedLength();

            entity.HasOne(d => d.BackupProject).WithMany(p => p.BackupProjectLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BackupProjectLog_BackupProject");
        });

        modelBuilder.Entity<BankName>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BankName__3214EC073EF8EC1B");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Bank_Sattlement>(entity =>
        {
            entity.HasOne(d => d.StaffUser).WithMany(p => p.Bank_Sattlements).HasConstraintName("FK_Bank_Sattlement_StaffUser");
        });

        modelBuilder.Entity<Blacklist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Blacklist_1");
        });

        modelBuilder.Entity<BlacklistMember>(entity =>
        {
            entity.HasKey(e => e.Seq).HasName("PK_Blacklist");

            entity.Property(e => e.IsAdmonish)
                .HasDefaultValue(0)
                .HasComment("1 = ตักเตือน , 2 = ลา");

            entity.HasOne(d => d.Blacklist).WithMany(p => p.BlacklistMembers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BlacklistMember_Blacklist");

            entity.HasOne(d => d.Member).WithMany(p => p.BlacklistMembers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BlacklistMember_Member");

            entity.HasOne(d => d.Zone).WithMany(p => p.BlacklistMembers).HasConstraintName("FK_BlacklistMember_Zone");
        });

        modelBuilder.Entity<BlacklistMemberBooking>(entity =>
        {
            entity.HasOne(d => d.Blacklist).WithMany(p => p.BlacklistMemberBookings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BlacklistMemberBooking_Blacklist");

            entity.HasOne(d => d.Member).WithMany(p => p.BlacklistMemberBookings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BlacklistMemberBooking_Member");

            entity.HasOne(d => d.Zone).WithMany(p => p.BlacklistMemberBookings).HasConstraintName("FK_BlacklistMemberBooking_Zone");
        });

        modelBuilder.Entity<Buddy>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.Buddies).HasConstraintName("FK_Buddy_Member");
        });

        modelBuilder.Entity<BuddyCancelLog>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.BuddyCancelLogs).HasConstraintName("FK_BuddyCancelLog_Member");
        });

        modelBuilder.Entity<BulkSMSVendor>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<BulkSMS_CallBack>(entity =>
        {
            entity.HasOne(d => d.BulkSMSVendor).WithMany(p => p.BulkSMS_CallBacks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BulkSMS_CallBack_BulkSMSVendor");
        });

        modelBuilder.Entity<BusTrip>(entity =>
        {
            entity.HasOne(d => d.Bus).WithMany(p => p.BusTrips).HasConstraintName("FK_BusTrips_SaveoneBuses");
        });

        modelBuilder.Entity<BustripLog>(entity =>
        {
            entity.HasOne(d => d.Bustrip).WithMany(p => p.BustripLogs).HasConstraintName("FK_BustripLogs_BusTrips");
        });

        modelBuilder.Entity<BypassPaymentStatus>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.PaymentStatus).IsFixedLength();
        });

        modelBuilder.Entity<COVID19VaccineDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_VaccineCovid19Data");

            entity.HasOne(d => d.Member).WithMany(p => p.COVID19VaccineData).HasConstraintName("FK_COVID19VaccineData_Member");
        });

        modelBuilder.Entity<CancelVIP>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CheckInLog>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.CheckInLogs).HasConstraintName("FK_CheckInLog_Member");

            entity.HasOne(d => d.Tran).WithMany(p => p.CheckInLogs).HasConstraintName("FK_CheckInLog_Transaction");
        });

        modelBuilder.Entity<CheckInLog_Backup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CheckInTopupLog>(entity =>
        {
            entity.HasOne(d => d.ReservationLoge).WithMany(p => p.CheckInTopupLogs).HasConstraintName("FK_CheckInTopupLog_ReservationLoge");

            entity.HasOne(d => d.Staff).WithMany(p => p.CheckInTopupLogs).HasConstraintName("FK_CheckInTopupLog_Staff");
        });

        modelBuilder.Entity<CheckLogeAbsence>(entity =>
        {
            entity.Property(e => e.ReservationLogeId).ValueGeneratedNever();

            entity.HasOne(d => d.ReservationLoge).WithOne(p => p.CheckLogeAbsence)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CheckLogeAbsence_ReservationLoge");
        });

        modelBuilder.Entity<CheckLogeAbsence_Backup>(entity =>
        {
            entity.Property(e => e.ReservationLogeId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Command>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC071EE6D716");
        });

        modelBuilder.Entity<ContractInfo>(entity =>
        {
            entity.Property(e => e.Address).HasDefaultValue("");
            entity.Property(e => e.Area).HasDefaultValue(0m);
            entity.Property(e => e.BranchName).HasDefaultValue("");
            entity.Property(e => e.ConductBusinessQty).HasDefaultValue(0);
            entity.Property(e => e.ConductBusinessType)
                .HasDefaultValue((byte)1)
                .HasComment("1=วัน,2=เดือน");
            entity.Property(e => e.ContractsQty).HasDefaultValue(0);
            entity.Property(e => e.Detail).HasDefaultValue("");
            entity.Property(e => e.FirstName).HasDefaultValue("");
            entity.Property(e => e.IdentificationNo).HasDefaultValue("");
            entity.Property(e => e.LastName).HasDefaultValue("");
            entity.Property(e => e.LogeNo).HasDefaultValue("");
            entity.Property(e => e.LogeQty).HasDefaultValue(0);
            entity.Property(e => e.PayEveryDayOfMonth).HasDefaultValue(0);
            entity.Property(e => e.PayThroughAcountNo).HasDefaultValue("");
            entity.Property(e => e.RecognizanceAmount).HasDefaultValue(0);
            entity.Property(e => e.RentalPeriodPerYear).HasDefaultValue(0);
            entity.Property(e => e.Zone).HasDefaultValue("");
        });

        modelBuilder.Entity<Coupon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Coupons");

            entity.HasOne(d => d.CouponDiscountType).WithMany(p => p.Coupons)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Coupon_CouponDiscountType");

            entity.HasOne(d => d.CouponType).WithMany(p => p.Coupons)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Coupon_CouponType");
        });

        modelBuilder.Entity<Covid19Healed>(entity =>
        {
            entity.Property(e => e.MemberId).ValueGeneratedNever();

            entity.HasOne(d => d.Member).WithOne(p => p.Covid19Healed)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Covid19Healed_Member");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.FoodTransactionAllianceId).HasDefaultValue(1);
        });

        modelBuilder.Entity<Delivery>(entity =>
        {
            entity.Property(e => e.Status).HasComment("0รอยืนยัน,1ยืนยันสั่งซื้อแล้ว,2รับของแล้ว");

            entity.HasOne(d => d.Buyer).WithMany(p => p.Deliveries).HasConstraintName("FK_Delivery_Member");
        });

        modelBuilder.Entity<DeliveryDetail>(entity =>
        {
            entity.HasOne(d => d.Delivery).WithMany(p => p.DeliveryDetails).HasConstraintName("FK_DeliveryDetail_Delivery");

            entity.HasOne(d => d.ProductModel).WithMany(p => p.DeliveryDetails).HasConstraintName("FK_DeliveryDetail_ProductModel");
        });

        modelBuilder.Entity<DeliveryTransaction>(entity =>
        {
            entity.HasOne(d => d.Customer).WithMany(p => p.DeliveryTransactions).HasConstraintName("FK_DeliveryTransaction_Customer");

            entity.HasOne(d => d.DeliveryTransactionStatus).WithMany(p => p.DeliveryTransactions).HasConstraintName("FK_DeliveryTransaction_DeliveryTransaction");

            entity.HasOne(d => d.FoodSender).WithMany(p => p.DeliveryTransactions).HasConstraintName("FK_DeliveryTransaction_FoodSender");

            entity.HasOne(d => d.PaymentType).WithMany(p => p.DeliveryTransactions).HasConstraintName("FK_DeliveryTransaction_PaymentType");
        });

        modelBuilder.Entity<DeliveryTransactionDetail>(entity =>
        {
            entity.HasOne(d => d.DeliveryTransactionDetailStatus).WithMany(p => p.DeliveryTransactionDetails).HasConstraintName("FK_DeliveryTransactionDetail_DeliveryTransactionDetailStatus");

            entity.HasOne(d => d.DeliveryTransaction).WithMany(p => p.DeliveryTransactionDetails).HasConstraintName("FK_DeliveryTransactionDetail_DeliveryTransaction");

            entity.HasOne(d => d.MemberFood).WithMany(p => p.DeliveryTransactionDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DeliveryTransactionDetail_MemberFood");
        });

        modelBuilder.Entity<DeliveryTransactionDetailStatus>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<DiscountRain_PaymentGateway>(entity =>
        {
            entity.HasKey(e => e.Seq).HasName("PK_DiscountRain_PaymentGateway_1");

            entity.HasOne(d => d.CancelByNavigation).WithMany(p => p.DiscountRain_PaymentGatewayCancelByNavigations).HasConstraintName("FK_DiscountRain_PaymentGateway_StaffUser1");

            entity.HasOne(d => d.CreateByNavigation).WithMany(p => p.DiscountRain_PaymentGatewayCreateByNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountRain_PaymentGateway_StaffUser");

            entity.HasOne(d => d.Zone).WithMany(p => p.DiscountRain_PaymentGateways)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiscountRain_PaymentGateway_Zone");
        });

        modelBuilder.Entity<District>(entity =>
        {
            entity.HasOne(d => d.ProvinceCodeNavigation).WithMany(p => p.Districts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_District_Province");
        });

        modelBuilder.Entity<DummyAlgorithm>(entity =>
        {
            entity.Property(e => e.Amount).HasDefaultValue(0);
            entity.Property(e => e.Amount2).HasDefaultValue(0);
            entity.Property(e => e.endTime).HasDefaultValue(1530);
            entity.Property(e => e.startTime).HasDefaultValue(1200);

            entity.HasOne(d => d.SubZone).WithMany(p => p.DummyAlgorithms).HasConstraintName("FK_DummyAlgorithm_SubZone");
        });

        modelBuilder.Entity<ERPAllocateLoge>(entity =>
        {
            entity.Property(e => e.ERPTransactionId).ValueGeneratedNever();

            entity.HasOne(d => d.ERPTransaction).WithOne(p => p.ERPAllocateLoge)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERPAllocateLoges_ERPTransactions");
        });

        modelBuilder.Entity<ERPCreateContract>(entity =>
        {
            entity.Property(e => e.ERPTransactionId).ValueGeneratedNever();

            entity.HasOne(d => d.ERPTransaction).WithOne(p => p.ERPCreateContract)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERPCreateContracts_ERPTransactions");
        });

        modelBuilder.Entity<ERPOperation>(entity =>
        {
            entity.Property(e => e.ERPTransactionId).ValueGeneratedNever();

            entity.HasOne(d => d.ERPTransaction).WithOne(p => p.ERPOperation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERPOperations_ERPTransactions");
        });

        modelBuilder.Entity<ERPReceipt>(entity =>
        {
            entity.Property(e => e.ERPTransactionId).ValueGeneratedNever();

            entity.HasOne(d => d.ERPTransaction).WithOne(p => p.ERPReceipt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERPReceipts_ERPTransactions");
        });

        modelBuilder.Entity<ERPSurveyRequirement>(entity =>
        {
            entity.Property(e => e.ERPTransactionId).ValueGeneratedNever();

            entity.HasOne(d => d.ERPTransaction).WithOne(p => p.ERPSurveyRequirement)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ERPSurveyRequirements_ERPTransactions");
        });

        modelBuilder.Entity<ExchangeEStampPerLogeRate>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Fine>(entity =>
        {
            entity.HasOne(d => d.FineType).WithMany(p => p.Fines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Fine_FineType");
        });

        modelBuilder.Entity<FoodHandler>(entity =>
        {
            entity.Property(e => e.MemberId).ValueGeneratedNever();

            entity.HasOne(d => d.Member).WithOne(p => p.FoodHandler)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FoodHandlers_Member");
        });

        modelBuilder.Entity<FoodMenu>(entity =>
        {
            entity.HasOne(d => d.FoodShop).WithMany(p => p.FoodMenus).HasConstraintName("FK_FoodMenu_FoodShop");
        });

        modelBuilder.Entity<FoodMenuAddOn>(entity =>
        {
            entity.HasOne(d => d.FoodMenu).WithMany(p => p.FoodMenuAddOns).HasConstraintName("FK_FoodMenuAddOn_FoodMenu");
        });

        modelBuilder.Entity<FoodMenuAddOnDetail>(entity =>
        {
            entity.HasOne(d => d.FoodMenuAddOn).WithMany(p => p.FoodMenuAddOnDetails).HasConstraintName("FK_FoodMenuAddOnDetail_FoodMenuAddOn");
        });

        modelBuilder.Entity<FoodMenuCategory>(entity =>
        {
            entity.HasOne(d => d.Category).WithMany(p => p.FoodMenuCategories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FoodMenuCategory_FoodCategory");

            entity.HasOne(d => d.FoodMenu).WithMany(p => p.FoodMenuCategories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FoodMenuCategory_FoodMenu");
        });

        modelBuilder.Entity<FoodMenuCustom>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<FoodMenuFlashSale>(entity =>
        {
            entity.Property(e => e.FoodMenuId).ValueGeneratedNever();
        });

        modelBuilder.Entity<FoodShop>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.FoodShops).HasConstraintName("FK_FoodShop_Member");
        });

        modelBuilder.Entity<FoodTransaction>(entity =>
        {
            entity.Property(e => e.FoodTransactionAllianceId).HasDefaultValue(1);

            entity.HasOne(d => d.Customer).WithMany(p => p.FoodTransactions).HasConstraintName("FK_FoodTransaction_Customer");

            entity.HasOne(d => d.Sender).WithMany(p => p.FoodTransactions).HasConstraintName("FK_FoodTransaction_FoodSender");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.FoodTransactions).HasConstraintName("FK_FoodTransaction_FoodTransactionStatus");
        });

        modelBuilder.Entity<FoodTransactionAlertConfiguration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_FoodTransactionAlertConfiguration_1");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<FoodTransactionCustomerEventLog>(entity =>
        {
            entity.HasOne(d => d.Customer).WithMany(p => p.FoodTransactionCustomerEventLogs).HasConstraintName("FK_FoodTransactionCustomerEventLog_Customer");
        });

        modelBuilder.Entity<FoodTransactionCustomerNotFound>(entity =>
        {
            entity.Property(e => e.FoodTransactionId).ValueGeneratedNever();
        });

        modelBuilder.Entity<FoodTransactionDetail>(entity =>
        {
            entity.HasOne(d => d.FoodMenu).WithMany(p => p.FoodTransactionDetails).HasConstraintName("FK_FoodTransactionDetail_FoodMenu");

            entity.HasOne(d => d.FoodTransaction).WithMany(p => p.FoodTransactionDetails).HasConstraintName("FK_FoodTransactionDetail_FoodTransaction");

            entity.HasOne(d => d.TransactionStatus).WithMany(p => p.FoodTransactionDetails).HasConstraintName("FK_FoodTransactionDetail_FoodTransactionStatus");
        });

        modelBuilder.Entity<FoodTransactionDetailAddOn>(entity =>
        {
            entity.HasOne(d => d.FoodTransactionDetail).WithMany(p => p.FoodTransactionDetailAddOns).HasConstraintName("FK_FoodTransactionDetailAddOn_FoodTransactionDetail");
        });

        modelBuilder.Entity<FoodTransactionImage>(entity =>
        {
            entity.Property(e => e.FoodtransactionId).ValueGeneratedNever();
        });

        modelBuilder.Entity<FoodTransactionMerchantDiscount>(entity =>
        {
            entity.HasKey(e => new { e.MemberId, e.PromotionPeriod }).HasName("PK_FoodTransactionMerchantDiscount_1");
        });

        modelBuilder.Entity<FoodTransactionPickUpLog>(entity =>
        {
            entity.Property(e => e.FoodTransactionId).ValueGeneratedNever();
        });

        modelBuilder.Entity<FoodTransactionStatus>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<FreeDay>(entity =>
        {
            entity.HasOne(d => d.Zone).WithMany(p => p.FreeDays)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FreeDays_Zone");
        });

        modelBuilder.Entity<FreshMarketCouponConfirm>(entity =>
        {
            entity.HasKey(e => e.Seq).HasName("PK_FreshMarketCoupon");
        });

        modelBuilder.Entity<FreshMarketReservationLoge>(entity =>
        {
            entity.Property(e => e.ElectronicAmount).HasDefaultValue(0m);
            entity.Property(e => e.FineAmount).HasDefaultValue(0m);
            entity.Property(e => e.FullAreaAmount).HasDefaultValue(0m);
        });

        modelBuilder.Entity<FreshMarketVip>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.FreshMarketVips).HasConstraintName("FK_FreshMarketVip_Member");
        });

        modelBuilder.Entity<FreshMarketVipAddByAdmin>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<FreshMarketVipStatusLog>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.FreshMarketVipStatusLogs).HasConstraintName("FK_FreshMarketVipStatusLog_Member");
        });

        modelBuilder.Entity<GetEStampLogeRate>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<KTBRegistration>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.KTBRegistrations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KTBRegistration_Member");
        });

        modelBuilder.Entity<KitchenWalletLog>(entity =>
        {
            entity.HasOne(d => d.DeliveryTransaction).WithMany(p => p.KitchenWalletLogs).HasConstraintName("FK_KitchenWalletLog_DeliveryTransaction");

            entity.HasOne(d => d.KitchenWalletType).WithMany(p => p.KitchenWalletLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KitchenWalletLog_KitchenWalletLogType");

            entity.HasOne(d => d.StaffUser).WithMany(p => p.KitchenWalletLogs).HasConstraintName("FK_KitchenWalletLog_StaffUser");
        });

        modelBuilder.Entity<KitchenWalletType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_KitchenWalletLogType");
        });

        modelBuilder.Entity<LandingPageBanner>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<LineApiLog>(entity =>
        {
            entity.HasOne(d => d.LineApiType).WithMany(p => p.LineApiLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LineApiLog_LineApiType");
        });

        modelBuilder.Entity<LineApiType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<LineTokenGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<LockerMember>(entity =>
        {
            entity.Property(e => e.LockerNo1).HasDefaultValue("");
            entity.Property(e => e.LockerNo2).HasDefaultValue("");
            entity.Property(e => e.LockerNo3).HasDefaultValue("");
            entity.Property(e => e.LogeNo).HasDefaultValue("");
        });

        modelBuilder.Entity<Loge>(entity =>
        {
            entity.Property(e => e.IsConner).HasDefaultValue(0);
            entity.Property(e => e.IsOpen).HasDefaultValue(1);
            entity.Property(e => e.IsRandom).HasDefaultValue(0);

            entity.HasOne(d => d.LogeGroup).WithMany(p => p.Loges)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Loge_LogeGroup");

            entity.HasOne(d => d.UpdateByNavigation).WithMany(p => p.Loges)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Loge_StaffUser");
        });

        modelBuilder.Entity<LogeCost>(entity =>
        {
            entity.HasOne(d => d.Loge).WithMany(p => p.LogeCosts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LogeCost_Loge");
        });

        modelBuilder.Entity<LogeCostByType>(entity =>
        {
            entity.HasOne(d => d.Zone).WithMany(p => p.LogeCostByTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LogeCostByType_Zone");
        });

        modelBuilder.Entity<LogeCostCustom>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.LogeCostCustoms).HasConstraintName("FK_LogeCostCustom_Member");

            entity.HasOne(d => d.SubZone).WithMany(p => p.LogeCostCustoms).HasConstraintName("FK_LogeCostCustom_SubZone");

            entity.HasOne(d => d.Zone).WithMany(p => p.LogeCostCustoms).HasConstraintName("FK_LogeCostCustom_Zone");
        });

        modelBuilder.Entity<LogeCostMX>(entity =>
        {
            entity.HasOne(d => d.Loge).WithMany(p => p.LogeCostMXes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LogeCostMX_Loge");

            entity.HasOne(d => d.SubZone).WithMany(p => p.LogeCostMXes).HasConstraintName("FK_LogeCostMX_SubZone");
        });

        modelBuilder.Entity<LogeCostPerDay>(entity =>
        {
            entity.HasOne(d => d.SubZone).WithMany(p => p.LogeCostPerDays)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LogeCostPerDay_SubZone");
        });

        modelBuilder.Entity<LogeEditForm>(entity =>
        {
            entity.Property(e => e.Remark2).IsFixedLength();

            entity.HasOne(d => d.Member).WithMany(p => p.LogeEditForms)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_LogeEditForms_Member");
        });

        modelBuilder.Entity<LogeGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.SubZone).WithMany(p => p.LogeGroups).HasConstraintName("FK_LogeGroup_SubZone");

            entity.HasOne(d => d.UpdateByNavigation).WithMany(p => p.LogeGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LogeGroup_StaffUser");

            entity.HasOne(d => d.Zone).WithMany(p => p.LogeGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LogeGroup_Zone");
        });

        modelBuilder.Entity<LogeGroupOpenDate>(entity =>
        {
            entity.Property(e => e.LogeGroupId).ValueGeneratedNever();

            entity.HasOne(d => d.LogeGroup).WithOne(p => p.LogeGroupOpenDate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LogeGroupOpenDate_LogeGroup");
        });

        modelBuilder.Entity<LogeLocation>(entity =>
        {
            entity.Property(e => e.LogeId).ValueGeneratedNever();
        });

        modelBuilder.Entity<LogeMapping>(entity =>
        {
            entity.Property(e => e.LogeId).ValueGeneratedNever();

            entity.HasOne(d => d.Loge).WithOne(p => p.LogeMappingLoge)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LogeMapping_Loge");

            entity.HasOne(d => d.MapLoge).WithMany(p => p.LogeMappingMapLoges)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LogeMapping_MapLoge");
        });

        modelBuilder.Entity<LogeReturnForm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_LogeReturn");
        });

        modelBuilder.Entity<LogeTemp>(entity =>
        {
            entity.Property(e => e.Seq).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Loge).WithMany(p => p.LogeTemps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LogeTemp_Loge");

            entity.HasOne(d => d.LogeType).WithMany(p => p.LogeTemps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LogeTemp_LogeType");
        });

        modelBuilder.Entity<LogeTemp_Master>(entity =>
        {
            entity.HasKey(e => new { e.LogeId, e.OpenCase }).HasName("PK_LogeTemp_Master_1");

            entity.Property(e => e.OpenCase).HasComment("1 = จันทร์ - พฤหัส , 2 = ศุกร์ - อาทิตย์");
            entity.Property(e => e.Status).HasDefaultValue(1);

            entity.HasOne(d => d.Loge).WithMany(p => p.LogeTemp_Masters)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LogeTemp_Master_Loge");
        });

        modelBuilder.Entity<LogeTemp_Offline>(entity =>
        {
            entity.Property(e => e.Seq).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Loge).WithMany(p => p.LogeTemp_Offlines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LogeTemp_Offline_Loge");

            entity.HasOne(d => d.LogeType).WithMany(p => p.LogeTemp_Offlines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LogeTemp_Offline_LogeType");
        });

        modelBuilder.Entity<LogicWorkLog>(entity =>
        {
            entity.HasOne(d => d.DummyAlgorithm).WithMany(p => p.LogicWorkLogs).HasConstraintName("FK_LogicWorkLog_DummyAlgorithm");

            entity.HasOne(d => d.ReservationSubzone).WithMany(p => p.LogicWorkLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LogicWorkLog_SubZone");

            entity.HasOne(d => d.Transaction).WithMany(p => p.LogicWorkLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LogicWorkLog_Transaction");
        });

        modelBuilder.Entity<LogicWorkLog_Backup>(entity =>
        {
            entity.Property(e => e.Seq).ValueGeneratedNever();
        });

        modelBuilder.Entity<LowerLogeLog>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Tran).WithMany(p => p.LowerLogeLogs).HasConstraintName("FK_LowerLogeLog_Transaction");
        });

        modelBuilder.Entity<MP_Member>(entity =>
        {
            entity.HasKey(e => new { e.MemberId, e.MP_ServiceId }).HasName("PK_MP_Member_1");

            entity.Property(e => e.Seq).ValueGeneratedOnAdd();

            entity.HasOne(d => d.CreateByNavigation).WithMany(p => p.MP_Members).HasConstraintName("FK_MP_Member_StaffUser");

            entity.HasOne(d => d.MP_Service).WithMany(p => p.MP_Members)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MP_Member_MP_Service");

            entity.HasOne(d => d.Member).WithMany(p => p.MP_Members)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MP_Member_Member");

            entity.HasOne(d => d.PaymentType).WithMany(p => p.MP_Members).HasConstraintName("FK_MP_Member_PaymentType");
        });

        modelBuilder.Entity<MP_Service>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<MP_Transaction>(entity =>
        {
            entity.Property(e => e.AmountToPay).HasDefaultValue(0m);
            entity.Property(e => e.BalanceAmount).HasDefaultValue(0m);
            entity.Property(e => e.BalanceBeforePay).HasDefaultValue(0m);
            entity.Property(e => e.FineAmount).HasDefaultValue(0m);
            entity.Property(e => e.NetAmount).HasDefaultValue(0.00m);
            entity.Property(e => e.TransactionStatusId).HasDefaultValue(1);

            entity.HasOne(d => d.CreateByNavigation).WithMany(p => p.MP_Transactions).HasConstraintName("FK_MP_Transaction_StaffUser");

            entity.HasOne(d => d.MP_Service).WithMany(p => p.MP_Transactions).HasConstraintName("FK_MP_Transaction_MP_Service");

            entity.HasOne(d => d.MUSavingLog).WithMany(p => p.MP_Transactions).HasConstraintName("FK_MP_Transaction_MUSavingLog");

            entity.HasOne(d => d.Member).WithMany(p => p.MP_Transactions).HasConstraintName("FK_MP_Transaction_Member");

            entity.HasOne(d => d.PaymentType).WithMany(p => p.MP_Transactions).HasConstraintName("FK_MP_Transaction_PaymentType");

            entity.HasOne(d => d.Tran).WithMany(p => p.MP_Transactions).HasConstraintName("FK_MP_Transaction_Transaction");

            entity.HasOne(d => d.TransactionStatus).WithMany(p => p.MP_Transactions).HasConstraintName("FK_MP_Transaction_MP_TransactionStatus");
        });

        modelBuilder.Entity<MP_TransactionStatus>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<MP_Transaction_Backup>(entity =>
        {
            entity.Property(e => e.Seq).ValueGeneratedNever();
            entity.Property(e => e.AmountToPay).HasDefaultValue(0m);
            entity.Property(e => e.BalanceAmount).HasDefaultValue(0m);
            entity.Property(e => e.BalanceBeforePay).HasDefaultValue(0m);
            entity.Property(e => e.FineAmount).HasDefaultValue(0m);
            entity.Property(e => e.NetAmount).HasDefaultValue(0.00m);
            entity.Property(e => e.TransactionStatusId).HasDefaultValue(1);
        });

        modelBuilder.Entity<MUSaving>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.MUSavings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MUSaving_Member");
        });

        modelBuilder.Entity<MUSavingLog>(entity =>
        {
            entity.HasOne(d => d.MUSavingLogType).WithMany(p => p.MUSavingLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MUSavingLog_MUSavingLogType");

            entity.HasOne(d => d.Member).WithMany(p => p.MUSavingLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MUSavingLog_Member");

            entity.HasOne(d => d.ReservationLoge).WithMany(p => p.MUSavingLogs).HasConstraintName("FK_MUSavingLog_ReservationLoge");

            entity.HasOne(d => d.StaffUser).WithMany(p => p.MUSavingLogs).HasConstraintName("FK_MUSavingLog_StaffUser");

            entity.HasOne(d => d.Transaction).WithMany(p => p.MUSavingLogs).HasConstraintName("FK_MUSavingLog_Transaction");
        });

        modelBuilder.Entity<MUSavingLog_Backup>(entity =>
        {
            entity.Property(e => e.Seq).ValueGeneratedNever();
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.Property(e => e.IsActive).HasDefaultValue(1);
            entity.Property(e => e.IsAdmin).HasDefaultValue(0);
            entity.Property(e => e.IsResCon).HasDefaultValue(0);
            entity.Property(e => e.IsResConMax).HasDefaultValue(0);
            entity.Property(e => e.IsResConZone2).HasDefaultValue(0);
            entity.Property(e => e.IsShowKTPRegister).HasDefaultValue(0);
            entity.Property(e => e.IsShowSCBRegister).HasDefaultValue(0);
            entity.Property(e => e.IsVIPZone1).HasDefaultValue(0);
            entity.Property(e => e.IsVIPZone2).HasDefaultValue(0);
            entity.Property(e => e.Zone1).HasDefaultValue(0);
            entity.Property(e => e.Zone2).HasDefaultValue(0);
            entity.Property(e => e.Zone2_Group).HasDefaultValue(0);
        });

        modelBuilder.Entity<MemberActivity>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.MemberActivities)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_MemberActivity_Member");
        });

        modelBuilder.Entity<MemberCoupon>(entity =>
        {
            entity.HasOne(d => d.Coupon).WithMany(p => p.MemberCoupons)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberCoupon_Coupon");

            entity.HasOne(d => d.Member).WithMany(p => p.MemberCoupons)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberCoupon_Member");

            entity.HasOne(d => d.ReservationLoge).WithMany(p => p.MemberCoupons).HasConstraintName("FK_MemberCoupon_ReservationLoge");
        });

        modelBuilder.Entity<MemberFood>(entity =>
        {
            entity.HasOne(d => d.FoodType).WithMany(p => p.MemberFoods).HasConstraintName("FK_MemberFood_FoodType");

            entity.HasOne(d => d.Member).WithMany(p => p.MemberFoods).HasConstraintName("FK_MemberFood_Member");
        });

        modelBuilder.Entity<MemberLeave>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.MemberLeaves).HasConstraintName("FK_MemberLeave_Member");

            entity.HasOne(d => d.Tran).WithMany(p => p.MemberLeaves).HasConstraintName("FK_MemberLeave_Transaction");
        });

        modelBuilder.Entity<MemberLeave_Backup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<MemberLog>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.MemberLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberLog_Member");
        });

        modelBuilder.Entity<MemberLogeGroup>(entity =>
        {
            entity.HasOne(d => d.LogeGroup).WithMany(p => p.MemberLogeGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberLogeGroup_LogeGroup");

            entity.HasOne(d => d.Member).WithMany(p => p.MemberLogeGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberLogeGroup_Member");
        });

        modelBuilder.Entity<MemberMenuList>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.MemberMenuListMembers).HasConstraintName("FK_MemberMenuList_Member");

            entity.HasOne(d => d.MenuCategory).WithMany(p => p.MemberMenuLists).HasConstraintName("FK_MemberMenuList_MenuCategory");

            entity.HasOne(d => d.UpdateByNavigation).WithMany(p => p.MemberMenuListUpdateByNavigations).HasConstraintName("FK_MemberMenuList_Member1");

            entity.HasOne(d => d.Zone).WithMany(p => p.MemberMenuLists).HasConstraintName("FK_MemberMenuList_Zone");
        });

        modelBuilder.Entity<MemberMerchantCategory>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.MemberMerchantCategoryMembers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberMerchantCategory_Member");

            entity.HasOne(d => d.MerchantCategory).WithMany(p => p.MemberMerchantCategories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberMerchantCategory_MerchantCategory");

            entity.HasOne(d => d.UpdateByNavigation).WithMany(p => p.MemberMerchantCategoryUpdateByNavigations).HasConstraintName("FK_MemberMerchantCategory_Member1");
        });

        modelBuilder.Entity<MemberPoint>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.MemberPoints)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberPoint_Member");
        });

        modelBuilder.Entity<MemberPointLog>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.MemberPointLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberPointLog_Member");

            entity.HasOne(d => d.MemberPointLogType).WithMany(p => p.MemberPointLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberPointLog_MemberPointLogType");

            entity.HasOne(d => d.StaffUser).WithMany(p => p.MemberPointLogs).HasConstraintName("FK_MemberPointLog_StaffUser");
        });

        modelBuilder.Entity<MemberProductImage>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.MemberProductImages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberProductImage_Member");
        });

        modelBuilder.Entity<MemberReservationTemplate>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.MemberReservationTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberReservationTemplate_Member");

            entity.HasOne(d => d.ReservationLogeElectricityType).WithMany(p => p.MemberReservationTemplates).HasConstraintName("FK_MemberReservationTemplate_ReservationLogeElectricityType");

            entity.HasOne(d => d.ReservationLogeElectronicType).WithMany(p => p.MemberReservationTemplates).HasConstraintName("FK_MemberReservationTemplate_ReservationLogeElectronicType");

            entity.HasOne(d => d.ReservationLogeType).WithMany(p => p.MemberReservationTemplates).HasConstraintName("FK_MemberReservationTemplate_ReservationLogeType");

            entity.HasOne(d => d.Zone).WithMany(p => p.MemberReservationTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberReservationTemplate_Zone");
        });

        modelBuilder.Entity<MemberTemp>(entity =>
        {
            entity.Property(e => e.Zone1).HasDefaultValue(0);
            entity.Property(e => e.Zone2).HasDefaultValue(0);
            entity.Property(e => e.Zone2_Group).HasDefaultValue(0);
        });

        modelBuilder.Entity<MemberTempLog>(entity =>
        {
            entity.Property(e => e.Zone1).HasDefaultValue(0);
            entity.Property(e => e.Zone2).HasDefaultValue(0);
            entity.Property(e => e.Zone2_Group).HasDefaultValue(0);
        });

        modelBuilder.Entity<MemberVip>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.MemberVips).HasConstraintName("FK_MemberVip_Member");

            entity.HasOne(d => d.Zone).WithMany(p => p.MemberVips).HasConstraintName("FK_MemberVip_Zone");
        });

        modelBuilder.Entity<MenuCategory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.UpdateByNavigation).WithMany(p => p.MenuCategories).HasConstraintName("FK_MenuCategory_StaffUser");

            entity.HasOne(d => d.Zone).WithMany(p => p.MenuCategories).HasConstraintName("FK_MenuCategory_Zone");
        });

        modelBuilder.Entity<MerchantCategory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.UpdateByNavigation).WithMany(p => p.MerchantCategories).HasConstraintName("FK_MerchantCategory_StaffUser");

            entity.HasOne(d => d.Zone).WithMany(p => p.MerchantCategories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MerchantCategory_Zone");
        });

        modelBuilder.Entity<MessengerFlashSale>(entity =>
        {
            entity.Property(e => e.FoodMenuId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MonthlyMemberLoge>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK_MonthlyMemberLoge_1");

            entity.Property(e => e.MemberId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Onesignal_PushNotification>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.Onesignal_PushNotifications).HasConstraintName("FK_Onesignal_PushNotification_Member");
        });

        modelBuilder.Entity<OpenTimeZone>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.UpdateByNavigation).WithMany(p => p.OpenTimeZones).HasConstraintName("FK_OpenTimeZone_StaffUser");

            entity.HasOne(d => d.Zone).WithMany(p => p.OpenTimeZones).HasConstraintName("FK_OpenTimeZone_Zone");
        });

        modelBuilder.Entity<OutStanding>(entity =>
        {
            entity.Property(e => e.Seq).ValueGeneratedNever();
        });

        modelBuilder.Entity<OutStandingDebtLog>(entity =>
        {
            entity.HasOne(d => d.UpdateByNavigation).WithMany(p => p.OutStandingDebtLogs).HasConstraintName("FK_OutStandingDebtLog_StaffUser");
        });

        modelBuilder.Entity<OutstandingDebt>(entity =>
        {
            entity.Property(e => e.Seq).ValueGeneratedNever();
        });

        modelBuilder.Entity<PDPA_Log>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.PDPA_Logs).HasConstraintName("FK_PDPA_Log_Member");
        });

        modelBuilder.Entity<Payin>(entity =>
        {
            entity.HasKey(e => e.Seq).HasName("PK_PayinLog");

            entity.HasOne(d => d.CreateByNavigation).WithMany(p => p.PayinCreateByNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payin_StaffUser");

            entity.HasOne(d => d.LastUpdateByNavigation).WithMany(p => p.PayinLastUpdateByNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payin_StaffUser1");
        });

        modelBuilder.Entity<PaymentGateway>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PaymentGatewayMethod>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.PaymentGateway).WithMany(p => p.PaymentGatewayMethods)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PaymentGatewayMethod_PaymentGateway");
        });

        modelBuilder.Entity<PaymentLog>(entity =>
        {
            entity.HasOne(d => d.PaymentType).WithMany(p => p.PaymentLogs).HasConstraintName("FK_PaymentLog_PaymentType");

            entity.HasOne(d => d.Transaction).WithMany(p => p.PaymentLogs).HasConstraintName("FK_PaymentLog_Transaction");
        });

        modelBuilder.Entity<PaymentOverWallet>(entity =>
        {
            entity.HasOne(d => d.Tran).WithMany(p => p.PaymentOverWallets).HasConstraintName("FK_PaymentOverWallet_Transaction");
        });

        modelBuilder.Entity<PostTransaction>(entity =>
        {
            entity.HasOne(d => d.Sender).WithMany(p => p.PostTransactions).HasConstraintName("FK_PostTransaction_FoodSender");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.PostTransactions).HasConstraintName("FK_PostTransaction_PostTransactionStatus");
        });

        modelBuilder.Entity<PostTransactionDetail>(entity =>
        {
            entity.HasOne(d => d.PostTransaction).WithMany(p => p.PostTransactionDetails).HasConstraintName("FK_PostTransactionDetail_PostTransaction");

            entity.HasOne(d => d.PostTypeNavigation).WithMany(p => p.PostTransactionDetails).HasConstraintName("FK_PostTransactionDetail_PostTransactionPostType");
        });

        modelBuilder.Entity<PostTransactionPostType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<PostTransactionStatus>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ProductModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ProductModel_1");

            entity.HasOne(d => d.MemberProductImage).WithMany(p => p.ProductModels)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductModel_MemberProductImage");
        });

        modelBuilder.Entity<QueueReservation>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.QueueReservations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QueueReservation_Member");
        });

        modelBuilder.Entity<QueueRound>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<QueueSMSSending>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.QueueSMSSendings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QueueSMSSending_Member");

            entity.HasOne(d => d.ReservationLoge).WithMany(p => p.QueueSMSSendings).HasConstraintName("FK_QueueSMSSending_ReservationLoge");

            entity.HasOne(d => d.StaffUser).WithMany(p => p.QueueSMSSendings).HasConstraintName("FK_QueueSMSSending_StaffUser");

            entity.HasOne(d => d.Transaction).WithMany(p => p.QueueSMSSendings).HasConstraintName("FK_QueueSMSSending_Transaction");
        });

        modelBuilder.Entity<ReceiptIndex>(entity =>
        {
            entity.Property(e => e.Seq).ValueGeneratedNever();

            entity.HasOne(d => d.RcptTypeNavigation).WithMany(p => p.ReceiptIndices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReceiptIndex_ReceiptType");
        });

        modelBuilder.Entity<ReceiptLog>(entity =>
        {
            entity.HasOne(d => d.CreateByNavigation).WithMany(p => p.ReceiptLogs).HasConstraintName("FK_ReceiptLog_StaffUser");

            entity.HasOne(d => d.RcptTypeNavigation).WithMany(p => p.ReceiptLogs).HasConstraintName("FK_ReceiptLog_ReceiptType");

            entity.HasOne(d => d.Tran).WithMany(p => p.ReceiptLogs).HasConstraintName("FK_ReceiptLog_Transaction");
        });

        modelBuilder.Entity<ReceiptType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).IsFixedLength();
        });

        modelBuilder.Entity<RecommendFoodCategory>(entity =>
        {
            entity.Property(e => e.CategoryId).ValueGeneratedNever();
        });

        modelBuilder.Entity<RegularLoge>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.RegularLoges).HasConstraintName("FK_RegularLoge_Member");

            entity.HasOne(d => d.PaymentType).WithMany(p => p.RegularLoges).HasConstraintName("FK_RegularLoge_PaymentType");

            entity.HasOne(d => d.RegularLogeType).WithMany(p => p.RegularLoges).HasConstraintName("FK_RegularLoge_RegularLogeType");

            entity.HasOne(d => d.Zone).WithMany(p => p.RegularLoges)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RegularLoge_RegularLogeZone");
        });

        modelBuilder.Entity<RegularLogeElectricType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<RegularLogePaymentLog>(entity =>
        {
            entity.HasOne(d => d.Invoice).WithMany(p => p.RegularLogePaymentLogs).HasConstraintName("FK_RegularLogePaymentLog_RegularLoge_Invoice");

            entity.HasOne(d => d.Member).WithMany(p => p.RegularLogePaymentLogs).HasConstraintName("FK_RegularLogePaymentLog_Member");

            entity.HasOne(d => d.PaymentType).WithMany(p => p.RegularLogePaymentLogs).HasConstraintName("FK_RegularLogePaymentLog_PaymentType");

            entity.HasOne(d => d.RegularLogeType).WithMany(p => p.RegularLogePaymentLogs).HasConstraintName("FK_RegularLogePaymentLog_RegularLogePaymentType");

            entity.HasOne(d => d.RegularLogeTypeNavigation).WithMany(p => p.RegularLogePaymentLogs).HasConstraintName("FK_RegularLogePaymentLog_RegularLogeType");

            entity.HasOne(d => d.TransactionStatus).WithMany(p => p.RegularLogePaymentLogs).HasConstraintName("FK_RegularLogePaymentLog_RegularLoge_TransactionStatus");
        });

        modelBuilder.Entity<RegularLogePaymentType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<RegularLogeType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<RegularLogeWaterType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<RegularLogeZone>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<RegularLoge_Invoice>(entity =>
        {
            entity.HasOne(d => d.InvoiceStatus).WithMany(p => p.RegularLoge_Invoices).HasConstraintName("FK_RegularLoge_Invoice_RegularLoge_InvoiceStatus");

            entity.HasOne(d => d.RegularLoge).WithMany(p => p.RegularLoge_Invoices).HasConstraintName("FK_RegularLoge_Invoice_RegularLoge_Invoice");
        });

        modelBuilder.Entity<RegularLoge_InvoiceStatus>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<RegularLoge_TransactionStatus>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ReprintLog>(entity =>
        {
            entity.HasOne(d => d.CreateByNavigation).WithMany(p => p.ReprintLogs).HasConstraintName("FK_ReprintLog_StaffUser");

            entity.HasOne(d => d.ReprintType).WithMany(p => p.ReprintLogs).HasConstraintName("FK_ReprintLog_ReprintType");

            entity.HasOne(d => d.Tran).WithMany(p => p.ReprintLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReprintLog_Transaction");
        });

        modelBuilder.Entity<ReservationLoge>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.ReservationLoges)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReservationLoge_Member");

            entity.HasOne(d => d.SubZone).WithMany(p => p.ReservationLoges).HasConstraintName("FK_ReservationLoge_SubZone");

            entity.HasOne(d => d.Zone).WithMany(p => p.ReservationLoges).HasConstraintName("FK_ReservationLoge_Zone");
        });

        modelBuilder.Entity<ReservationLogeAdditional>(entity =>
        {
            entity.Property(e => e.AreaAmount).HasDefaultValue(0m);
            entity.Property(e => e.CarParkAmount).HasDefaultValue(0m);
            entity.Property(e => e.ElectricityAmount).HasDefaultValue(0m);
            entity.Property(e => e.LogeAmount).HasDefaultValue(0m);

            entity.HasOne(d => d.Member).WithMany(p => p.ReservationLogeAdditionals).HasConstraintName("FK_ReservationLogeAdditional_Member");

            entity.HasOne(d => d.ReservationLoge).WithMany(p => p.ReservationLogeAdditionals).HasConstraintName("FK_ReservationLogeAdditional_ReservationLoge");

            entity.HasOne(d => d.UpdateByNavigation).WithMany(p => p.ReservationLogeAdditionals).HasConstraintName("FK_ReservationLogeAdditional_StaffUser");
        });

        modelBuilder.Entity<ReservationLogeAdditional_Backup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AreaAmount).HasDefaultValue(0m);
            entity.Property(e => e.CarParkAmount).HasDefaultValue(0m);
            entity.Property(e => e.ElectricityAmount).HasDefaultValue(0m);
            entity.Property(e => e.LogeAmount).HasDefaultValue(0m);

            entity.HasOne(d => d.Member).WithMany(p => p.ReservationLogeAdditional_Backups).HasConstraintName("FK_ReservationLogeAdditional_Backup_Member");

            entity.HasOne(d => d.UpdateByNavigation).WithMany(p => p.ReservationLogeAdditional_Backups).HasConstraintName("FK_ReservationLogeAdditional_Backup_StaffUser");
        });

        modelBuilder.Entity<ReservationLogeDetail>(entity =>
        {
            entity.HasKey(e => new { e.LogeId, e.ReservationDate }).HasName("PK_ReservationLogeDetail_1");

            entity.HasOne(d => d.Loge).WithMany(p => p.ReservationLogeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReservationLogeDetail_Loge");

            entity.HasOne(d => d.ReservationLoge).WithMany(p => p.ReservationLogeDetails).HasConstraintName("FK_ReservationLogeDetail_ReservationLoge");
        });

        modelBuilder.Entity<ReservationLogeElectricityType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ReservationLogeLimit>(entity =>
        {
            entity.HasOne(d => d.SubZone).WithMany(p => p.ReservationLogeLimits).HasConstraintName("FK_ReservationLogeLimit_SubZone");
        });

        modelBuilder.Entity<ReservationLogeLimitLog>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ReservationLogeMx>(entity =>
        {
            entity.HasOne(d => d.Loge).WithMany(p => p.ReservationLogeMxes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReservationLogeMx_Loge");

            entity.HasOne(d => d.Tran).WithMany(p => p.ReservationLogeMxes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReservationLogeMx_Transaction");
        });

        modelBuilder.Entity<ReservationLogeType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ReservationLoge_Backup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SCBQrcodePayment>(entity =>
        {
            entity.HasOne(d => d.Tran).WithMany(p => p.SCBQrcodePayments).HasConstraintName("FK_SCBQrcodePayment_Transaction");
        });

        modelBuilder.Entity<SCBRegistration>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.SCBRegistrations).HasConstraintName("FK_SCBRegistration_Member");
        });

        modelBuilder.Entity<SGDiscount>(entity =>
        {
            entity.HasOne(d => d.LogeGroup).WithMany(p => p.SGDiscounts).HasConstraintName("FK_SGDiscount_LogeGroup");

            entity.HasOne(d => d.SaveoneGo_ZoneMarket).WithMany(p => p.SGDiscounts).HasConstraintName("FK_SGDiscount_SaveoneGo_ZoneMarket");
        });

        modelBuilder.Entity<SGPointLog>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.SGPointLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SGPointLogs_Member");

            entity.HasOne(d => d.SGPointLogType).WithMany(p => p.SGPointLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SGPointLogs_SGPointLogTypes");

            entity.HasOne(d => d.StaffUser).WithMany(p => p.SGPointLogs).HasConstraintName("FK_SGPointLogs_StaffUser");
        });

        modelBuilder.Entity<SGPromotion>(entity =>
        {
            entity.HasOne(d => d.SGPromotionType).WithMany(p => p.SGPromotions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SGPromotion_SGPromotionType");

            entity.HasOne(d => d.TargetType).WithMany(p => p.SGPromotions).HasConstraintName("FK_SGPromotion_SaveoneGo_MemberPrivileges");
        });

        modelBuilder.Entity<SGPromotion_Target>(entity =>
        {
            entity.HasOne(d => d.SGPromotion).WithMany(p => p.SGPromotion_Targets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SGPromotion_Target_SGPromotion");

            entity.HasOne(d => d.Target).WithMany(p => p.SGPromotion_Targets).HasConstraintName("FK_SGPromotion_Target_MemberPrivileges");
        });

        modelBuilder.Entity<SGPromotion_ZoneMarket>(entity =>
        {
            entity.HasOne(d => d.SGPromotion).WithMany(p => p.SGPromotion_ZoneMarkets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SGPromotion_ZoneMarket_SGPromotion");

            entity.HasOne(d => d.SaveoneGo_ZoneMarket).WithMany(p => p.SGPromotion_ZoneMarkets).HasConstraintName("FK_SGPromotion_ZoneMarket_SaveoneGo_ZoneMarket");
        });

        modelBuilder.Entity<SGSavingLog>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.SGSavingLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SGSavingLogs_Member");

            entity.HasOne(d => d.SGSavingLogType).WithMany(p => p.SGSavingLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SGSavingLogs_SGSavingLogTypes");

            entity.HasOne(d => d.StaffUser).WithMany(p => p.SGSavingLogs).HasConstraintName("FK_SGSavingLogs_StaffUser");

            entity.HasOne(d => d.Transaction).WithMany(p => p.SGSavingLogs).HasConstraintName("FK_SGSavingLogs_Transaction");
        });

        modelBuilder.Entity<SaveonGO_TransactionGetLogeNoPaid>(entity =>
        {
            entity.Property(e => e.CreateDate).IsFixedLength();
            entity.Property(e => e.LogeName).IsFixedLength();

            entity.HasOne(d => d.Member).WithMany(p => p.SaveonGO_TransactionGetLogeNoPaids).HasConstraintName("FK_SaveonGO_TransactionGetLogeNoPaid_Member");

            entity.HasOne(d => d.SaveoneGoMember).WithMany(p => p.SaveonGO_TransactionGetLogeNoPaids).HasConstraintName("FK_SaveonGO_TransactionGetLogeNoPaid_SaveoneGo_Member");

            entity.HasOne(d => d.Transaction).WithMany(p => p.SaveonGO_TransactionGetLogeNoPaids)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaveonGO_TransactionGetLogeNoPaid_Transaction");
        });

        modelBuilder.Entity<SaveonGO_TransactionGetLogeNoPaid_Backup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreateDate).IsFixedLength();
            entity.Property(e => e.LogeName).IsFixedLength();
        });

        modelBuilder.Entity<SaveoneGo_Blacklist>(entity =>
        {
            entity.HasOne(d => d.BlacklistMemberBooking).WithMany(p => p.SaveoneGo_Blacklists).HasConstraintName("FK_SaveoneGo_Blacklist_BlacklistMemberBooking");

            entity.HasOne(d => d.Member).WithMany(p => p.SaveoneGo_Blacklists)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SaveoneGo_Blacklist_Member");

            entity.HasOne(d => d.Transaction).WithMany(p => p.SaveoneGo_Blacklists).HasConstraintName("FK_SaveoneGo_Blacklist_Transaction");
        });

        modelBuilder.Entity<SaveoneGo_Blacklist_Backup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SaveoneGo_Buddy>(entity =>
        {
            entity.HasOne(d => d.MemberId_BuddyNavigation).WithMany(p => p.SaveoneGo_BuddyMemberId_BuddyNavigations)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SaveoneGo_Buddy_MemberBuddy");

            entity.HasOne(d => d.MemberId_HostNavigation).WithMany(p => p.SaveoneGo_BuddyMemberId_HostNavigations).HasConstraintName("FK_SaveoneGo_Buddy_MemberHost");
        });

        modelBuilder.Entity<SaveoneGo_BuddyCancel>(entity =>
        {
            entity.HasOne(d => d.SaveoneGo_Buddy).WithMany(p => p.SaveoneGo_BuddyCancels)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SaveoneGo_BuddyCancel_MemberBuddy");
        });

        modelBuilder.Entity<SaveoneGo_BuddyStatus>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SaveoneGo_CheckScore>(entity =>
        {
            entity.Property(e => e.SaveoneGo_ZoneMarketId).HasDefaultValue(1);

            entity.HasOne(d => d.Member).WithMany(p => p.SaveoneGo_CheckScores)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SaveoneGo_CheckScore_Member");

            entity.HasOne(d => d.SaveoneGo_ZoneMarket).WithMany(p => p.SaveoneGo_CheckScores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaveoneGo_CheckScore_SaveoneGo_ZoneMarket");

            entity.HasOne(d => d.Transaction).WithMany(p => p.SaveoneGo_CheckScores).HasConstraintName("FK_SaveoneGo_CheckScore_Transaction");
        });

        modelBuilder.Entity<SaveoneGo_CheckScoreDetail>(entity =>
        {
            entity.Property(e => e.SaveoneGo_ZoneMarketId).HasDefaultValue(1);

            entity.HasOne(d => d.SaveoneGo_CheckScore).WithMany(p => p.SaveoneGo_CheckScoreDetails)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SaveoneGo_CheckScoreDetail_SaveoneGo_CheckScore");

            entity.HasOne(d => d.SaveoneGo_ZoneMarket).WithMany(p => p.SaveoneGo_CheckScoreDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaveoneGo_CheckScoreDetail_SaveoneGo_ZoneMarket");

            entity.HasOne(d => d.TopicList).WithMany(p => p.SaveoneGo_CheckScoreDetails)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SaveoneGo_CheckScoreDetail_SaveoneGo_CheckScoreTopicList");
        });

        modelBuilder.Entity<SaveoneGo_CheckScoreDetail_Backup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SaveoneGo_CheckScoreDetail_Test>(entity =>
        {
            entity.Property(e => e.SaveoneGo_ZoneMarketId).HasDefaultValue(1);

            entity.HasOne(d => d.SaveoneGo_CheckScore).WithMany(p => p.SaveoneGo_CheckScoreDetail_Tests)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SaveoneGo_CheckScoreDetail_Test_SaveoneGo_CheckScore_Test");

            entity.HasOne(d => d.SaveoneGo_ZoneMarket).WithMany(p => p.SaveoneGo_CheckScoreDetail_Tests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaveoneGo_CheckScoreDetail_Test_SaveoneGo_ZoneMarket");

            entity.HasOne(d => d.TopicList).WithMany(p => p.SaveoneGo_CheckScoreDetail_Tests)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SaveoneGo_CheckScoreDetail_Test_SaveoneGo_CheckScoreTopicList");
        });

        modelBuilder.Entity<SaveoneGo_CheckScoreSpecial>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.SaveoneGo_CheckScoreSpecials)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SaveoneGo_CheckScoreSpecial_Member");

            entity.HasOne(d => d.Transaction).WithMany(p => p.SaveoneGo_CheckScoreSpecials).HasConstraintName("FK_SaveoneGo_CheckScoreSpecial_Transaction");
        });

        modelBuilder.Entity<SaveoneGo_CheckScoreSpecial_Backup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SaveoneGo_CheckScoreTopic>(entity =>
        {
            entity.HasOne(d => d.SaveoneGo_ZoneMarket).WithMany(p => p.SaveoneGo_CheckScoreTopics)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaveoneGo_CheckScoreTopic_SaveoneGo_ZoneMarket");
        });

        modelBuilder.Entity<SaveoneGo_CheckScoreTopicList>(entity =>
        {
            entity.Property(e => e.SaveoneGo_ZoneMarketId).HasDefaultValue(1);

            entity.HasOne(d => d.SaveoneGo_ZoneMarket).WithMany(p => p.SaveoneGo_CheckScoreTopicLists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaveoneGo_CheckScoreTopicList_SaveoneGo_ZoneMarket");

            entity.HasOne(d => d.Topic).WithMany(p => p.SaveoneGo_CheckScoreTopicLists)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SaveoneGo_CheckScoreTopicList_SaveoneGo_CheckScoreTopic");
        });

        modelBuilder.Entity<SaveoneGo_CheckScore_Backup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SaveoneGo_CheckScore_Test>(entity =>
        {
            entity.Property(e => e.SaveoneGo_ZoneMarketId).HasDefaultValue(1);

            entity.HasOne(d => d.Member).WithMany(p => p.SaveoneGo_CheckScore_Tests)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SaveoneGo_CheckScore_Test_Member");

            entity.HasOne(d => d.SaveoneGo_ZoneMarket).WithMany(p => p.SaveoneGo_CheckScore_Tests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaveoneGo_CheckScore_Test_SaveoneGo_ZoneMarket");
        });

        modelBuilder.Entity<SaveoneGo_Compensation>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.SaveoneGo_Compensations).HasConstraintName("FK_SaveoneGo_Compensation_Member");

            entity.HasOne(d => d.SaveoneGo_CompensationType).WithMany(p => p.SaveoneGo_Compensations).HasConstraintName("FK_SaveoneGo_Compensation_SaveoneGo_CompensationType");
        });

        modelBuilder.Entity<SaveoneGo_CompensationType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SaveoneGo_CustomerReview>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.SaveoneGo_CustomerReviews)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SaveoneGo_CustomerReview_Member");

            entity.HasOne(d => d.SaveoneGo_Customer).WithMany(p => p.SaveoneGo_CustomerReviews)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SaveoneGo_CustomerReview_SaveoneGo_Customer");
        });

        modelBuilder.Entity<SaveoneGo_CustomerReviewImage>(entity =>
        {
            entity.HasOne(d => d.Review).WithMany(p => p.SaveoneGo_CustomerReviewImages)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SaveoneGo_CustomerReviewImages_SaveoneGo_CustomerReview");
        });

        modelBuilder.Entity<SaveoneGo_CustomerReviewList>(entity =>
        {
            entity.HasOne(d => d.Question).WithMany(p => p.SaveoneGo_CustomerReviewLists)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SaveoneGo_CustomerReviewList_SaveoneGo_CustomerReviewQuestion");

            entity.HasOne(d => d.Review).WithMany(p => p.SaveoneGo_CustomerReviewLists)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SaveoneGo_CustomerReviewList_SaveoneGo_CustomerReview");
        });

        modelBuilder.Entity<SaveoneGo_Fine>(entity =>
        {
            entity.HasOne(d => d.ElectricityType_Acctual).WithMany(p => p.SaveoneGo_Fines).HasConstraintName("FK_SaveoneGo_Fine_ReservationLogeElectricityType");

            entity.HasOne(d => d.ElectronicType_Acctual).WithMany(p => p.SaveoneGo_Fines).HasConstraintName("FK_SaveoneGo_Fine_ReservationLogeElectronicType");

            entity.HasOne(d => d.Member).WithMany(p => p.SaveoneGo_Fines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SaveoneGo_Fine_Member");

            entity.HasOne(d => d.New_Transaction).WithMany(p => p.SaveoneGo_FineNew_Transactions).HasConstraintName("FK_SaveoneGo_Fine_Transaction_New");

            entity.HasOne(d => d.Transaction).WithMany(p => p.SaveoneGo_FineTransactions).HasConstraintName("FK_SaveoneGo_Fine_Transaction");
        });

        modelBuilder.Entity<SaveoneGo_FineStatus>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SaveoneGo_Fine_Backup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SaveoneGo_Market>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Zone).WithMany(p => p.SaveoneGo_Markets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaveoneGo_Market_Zone");
        });

        modelBuilder.Entity<SaveoneGo_Member>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.SaveoneGo_Members).HasConstraintName("FK_SaveoneGo_Member_Member");
        });

        modelBuilder.Entity<SaveoneGo_MemberImage>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.SaveoneGo_MemberImages)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SaveoneGo_MemberImages_Member");

            entity.HasOne(d => d.SaveoneGo_Member).WithMany(p => p.SaveoneGo_MemberImages).HasConstraintName("FK_SaveoneGo_MemberImages_SaveoneGo_Member");
        });

        modelBuilder.Entity<SaveoneGo_MemberRobinson>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.SaveoneGo_MemberRobinsons).HasConstraintName("FK_SaveoneGo_MemberRobinson_Member");
        });

        modelBuilder.Entity<SaveoneGo_MemberScore_Freeze>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.SaveoneGo_MemberScore_Freezes).HasConstraintName("FK_SaveoneGo_MemberScore_Freeze");
        });

        modelBuilder.Entity<SaveoneGo_MemberSocialMedium>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.SaveoneGo_MemberSocialMedia).HasConstraintName("FK_SaveoneGo_MemberSocialMedia_Member");
        });

        modelBuilder.Entity<SaveoneGo_MemberStamp>(entity =>
        {
            entity.Property(e => e.SaveoneGo_ZoneMarketId).HasDefaultValue(1);

            entity.HasOne(d => d.Member).WithMany(p => p.SaveoneGo_MemberStamps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaveoneGo_MemberStamp_Member");

            entity.HasOne(d => d.SaveoneGo_ZoneMarket).WithMany(p => p.SaveoneGo_MemberStamps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaveoneGo_MemberStamp_SaveoneGo_ZoneMarket");

            entity.HasOne(d => d.StaffUser).WithMany(p => p.SaveoneGo_MemberStamps).HasConstraintName("FK_SaveoneGo_MemberStamp_StaffUser");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.SaveoneGo_MemberStamps).HasConstraintName("FK_SaveoneGo_MemberStamp_SaveoneGo_MemberStampStatus");
        });

        modelBuilder.Entity<SaveoneGo_MemberStampStatus>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SaveoneGo_MemberStamp_GetLog>(entity =>
        {
            entity.Property(e => e.SaveoneGo_ZoneMarketId).HasDefaultValue(1);

            entity.HasOne(d => d.Member).WithMany(p => p.SaveoneGo_MemberStamp_GetLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaveoneGo_MemberStamp_GetLog_Member");

            entity.HasOne(d => d.SaveoneGo_ZoneMarket).WithMany(p => p.SaveoneGo_MemberStamp_GetLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaveoneGo_MemberStamp_GetLog_SaveoneGo_ZoneMarket");

            entity.HasOne(d => d.Stamp).WithMany(p => p.SaveoneGo_MemberStamp_GetLogs).HasConstraintName("FK_SaveoneGo_MemberStamp_SaveoneGo_MemberStamp");
        });

        modelBuilder.Entity<SaveoneGo_Member_FleaMarket>(entity =>
        {
            entity.HasOne(d => d.FleaMarketShopType).WithMany(p => p.SaveoneGo_Member_FleaMarkets).HasConstraintName("FK_SaveoneGo_Member_FleaMarket_SaveoneGo_FleaMarketShopType");

            entity.HasOne(d => d.SaveoneGo_Member).WithMany(p => p.SaveoneGo_Member_FleaMarkets).HasConstraintName("FK_SaveoneGo_Member_FleaMarket_SaveoneGo_Member");
        });

        modelBuilder.Entity<SaveoneGo_Member_Privilege>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.SaveoneGo_Member_Privileges).HasConstraintName("FK_SaveoneGo_Member_Privilege_Member");

            entity.HasOne(d => d.Privilege).WithMany(p => p.SaveoneGo_Member_Privileges).HasConstraintName("FK_SaveoneGo_Member_Privilege_SaveoneGo_MemberPrivileges");
        });

        modelBuilder.Entity<SaveoneGo_Member_PrivilegesLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SaveoneGo_Member_PrivilegeLog");

            entity.HasOne(d => d.Member).WithMany(p => p.SaveoneGo_Member_PrivilegesLogs).HasConstraintName("FK_SaveoneGo_Member_PrivilegeLog_Member");

            entity.HasOne(d => d.ToPrivilege).WithMany(p => p.SaveoneGo_Member_PrivilegesLogs).HasConstraintName("FK_SaveoneGo_Member_PrivilegeLog_SaveoneGo_MemberPrivileges");
        });

        modelBuilder.Entity<SaveoneGo_Member_TestScore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SaveoneGo_MemberTestScore");

            entity.HasOne(d => d.Member).WithMany(p => p.SaveoneGo_Member_TestScores).HasConstraintName("FK_SaveoneGo_MemberTestScore_Member");
        });

        modelBuilder.Entity<SaveoneGo_Queue>(entity =>
        {
            entity.Property(e => e.isAdvanceBooking).HasDefaultValue(0);
            entity.Property(e => e.isUseGoPoint).HasDefaultValue(0);

            entity.HasOne(d => d.Member).WithMany(p => p.SaveoneGo_Queues).HasConstraintName("FK_SaveoneGo_Queue_Member");

            entity.HasOne(d => d.SaveoneGo_ZoneMarket).WithMany(p => p.SaveoneGo_Queues).HasConstraintName("FK_SaveoneGo_Queue_SaveoneGo_ZoneMarket");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.SaveoneGo_Queues).HasConstraintName("FK_SaveoneGo_Queue_SaveoneGo_QueueStatus");
        });

        modelBuilder.Entity<SaveoneGo_QueueStatus>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SaveoneGo_Whitelist>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.SaveoneGo_Whitelists)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SaveoneGo_Whitelist_Member");
        });

        modelBuilder.Entity<SaveoneGo_ZoneMarket>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.SaveoneGo_Market).WithMany(p => p.SaveoneGo_ZoneMarkets).HasConstraintName("FK_SaveoneGo_ZoneMarket_SaveoneGo_Market");

            entity.HasOne(d => d.Zone).WithMany(p => p.SaveoneGo_ZoneMarkets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaveoneGo_ZoneMarket_Zone");
        });

        modelBuilder.Entity<SaveoneGo_Zone_SubZone>(entity =>
        {
            entity.HasOne(d => d.SaveoneGo_ZoneMarket).WithMany(p => p.SaveoneGo_Zone_SubZones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaveoneGo_Zone_SubZone_SaveoneGo_ZoneMarket");

            entity.HasOne(d => d.SubZone).WithMany(p => p.SaveoneGo_Zone_SubZones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaveoneGo_Zone_SubZone_SubZone");

            entity.HasOne(d => d.Zone).WithMany(p => p.SaveoneGo_Zone_SubZones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaveoneGo_Zone_SubZone_Zone");
        });

        modelBuilder.Entity<SavingReceive>(entity =>
        {
            entity.HasOne(d => d.ReceiveByNavigation).WithMany(p => p.SavingReceives).HasConstraintName("FK_SavingReceive_StaffUser");

            entity.HasOne(d => d.ReservationLoge).WithMany(p => p.SavingReceives)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SavingReceive_ReservationLoge");
        });

        modelBuilder.Entity<SavingReceive2>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SavingTopup>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.SavingTopups).HasConstraintName("FK_SavingTopup_Member");
        });

        modelBuilder.Entity<SelectLogeFullLog>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.SelectLogeFullLogs)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SelectLogeFullLog_Member");
        });

        modelBuilder.Entity<ShopType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ShoppingCart>(entity =>
        {
            entity.HasOne(d => d.PaymentGateway).WithMany(p => p.ShoppingCarts).HasConstraintName("FK_ShoppingCart_PaymentGateway");

            entity.HasOne(d => d.ShoppingCartStatus).WithMany(p => p.ShoppingCarts).HasConstraintName("FK_ShoppingCart_ShoppingCartStatus");
        });

        modelBuilder.Entity<ShoppingCartDetail>(entity =>
        {
            entity.HasOne(d => d.Menu).WithMany(p => p.ShoppingCartDetails).HasConstraintName("FK_ShoppingCartDetail_MemberMenuList");

            entity.HasOne(d => d.ShoppingCart).WithMany(p => p.ShoppingCartDetails).HasConstraintName("FK_ShoppingCartDetail_ShoppingCart");
        });

        modelBuilder.Entity<ShoppingCartStatus>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SkipOTP>(entity =>
        {
            entity.HasOne(d => d.UpdateByNavigation).WithMany(p => p.SkipOTPs).HasConstraintName("FK_SkipOTP_StaffUser");
        });

        modelBuilder.Entity<SmsResultLog>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.SmsResultLogs).HasConstraintName("FK_SmsResultLog_Member");
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasOne(d => d.UpdateByNavigation).WithMany(p => p.Staff)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Staff_StaffUser");
        });

        modelBuilder.Entity<StaffLoginLocationLog>(entity =>
        {
            entity.HasOne(d => d.Staff).WithMany(p => p.StaffLoginLocationLogs).HasConstraintName("FK_StaffLoginLocationLog_Staff");
        });

        modelBuilder.Entity<StaffUser>(entity =>
        {
            entity.HasOne(d => d.StaffNavigation).WithMany(p => p.StaffUsers).HasConstraintName("FK_StaffUser_Staff");

            entity.HasOne(d => d.UpdateByNavigation).WithMany(p => p.InverseUpdateByNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StaffUser_StaffUser");

            entity.HasOne(d => d.UserLevel).WithMany(p => p.StaffUsers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StaffUser_UserLevel");
        });

        modelBuilder.Entity<StaffUserRight>(entity =>
        {
            entity.HasKey(e => e.Seq).HasName("PK_StaffUserRight_1");

            entity.HasOne(d => d.Right).WithMany(p => p.StaffUserRights)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StaffUserRight_Right");

            entity.HasOne(d => d.StaffUser).WithMany(p => p.StaffUserRights)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StaffUserRight_StaffUser");
        });

        modelBuilder.Entity<StallMarkerLogeLimit>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.StallMarkerLogeLimits).HasConstraintName("FK_StallMarkerLogeLimit_Member");
        });

        modelBuilder.Entity<StatisticType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SubZone>(entity =>
        {
            entity.Property(e => e.SaleGroup).HasDefaultValue(1);

            entity.HasOne(d => d.Zone).WithMany(p => p.SubZones).HasConstraintName("FK_SubZone_Zone");
        });

        modelBuilder.Entity<SurveyMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07CF558F16");
        });

        modelBuilder.Entity<TempCustomer>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FoodTransactionAllianceId).HasDefaultValue(1);
        });

        modelBuilder.Entity<TempMU>(entity =>
        {
            entity.Property(e => e.MemberId).ValueGeneratedNever();
        });

        modelBuilder.Entity<TempWallet>(entity =>
        {
            entity.Property(e => e.MemberId).ValueGeneratedNever();
        });

        modelBuilder.Entity<TemporaryFoodMenu>(entity =>
        {
            entity.HasOne(d => d.FoodShop).WithMany(p => p.TemporaryFoodMenus).HasConstraintName("FK_TemporaryFoodMenu_FoodShop");
        });

        modelBuilder.Entity<TemporaryFoodMenuAddOn>(entity =>
        {
            entity.HasOne(d => d.TemporaryFoodMenu).WithMany(p => p.TemporaryFoodMenuAddOns).HasConstraintName("FK_TemporaryFoodMenuAddOn_TemporaryFoodMenu");
        });

        modelBuilder.Entity<TemporaryFoodMenuAddOnDetail>(entity =>
        {
            entity.HasOne(d => d.FoodMenuAddOn).WithMany(p => p.TemporaryFoodMenuAddOnDetails).HasConstraintName("FK_TemporaryFoodMenuAddOnDetail_TemporaryFoodMenuAddOn");
        });

        modelBuilder.Entity<ToiletCloseFault>(entity =>
        {
            entity.HasOne(d => d.ToiletFault).WithMany(p => p.ToiletCloseFaults).HasConstraintName("FK_ToiletCloseFaults_ToiletFaults");
        });

        modelBuilder.Entity<ToiletEquipment>(entity =>
        {
            entity.HasOne(d => d.ToiletType).WithMany(p => p.ToiletEquipments).HasConstraintName("FK_ToiletEquipments_ToiletTypes");

            entity.HasOne(d => d.ToiletZone).WithMany(p => p.ToiletEquipments).HasConstraintName("FK_ToiletEquipments_ToiletZones");
        });

        modelBuilder.Entity<ToiletFault>(entity =>
        {
            entity.HasOne(d => d.ToiletEquipment).WithMany(p => p.ToiletFaults).HasConstraintName("FK_ToiletFaults_ToiletEquipments");
        });

        modelBuilder.Entity<ToiletFaultLog>(entity =>
        {
            entity.HasOne(d => d.ToiletFault).WithMany(p => p.ToiletFaultLogs).HasConstraintName("FK_ToiletFaultLogs_ToiletFaults");
        });

        modelBuilder.Entity<ToiletFaultPickingList>(entity =>
        {
            entity.HasOne(d => d.ToiletFault).WithMany(p => p.ToiletFaultPickingLists).HasConstraintName("FK_ToiletFaultPickingLists_ToiletFaults");
        });

        modelBuilder.Entity<ToiletType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ToiletZone>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.ToTable("Transaction", tb => tb.HasComment("RPI = Request Payment Input\r\nRPO = Request Payment Output\r\nPRN = Payment result for HTTP post parameter\r\nPRS =  Payment result for respUrl (Silent Post)"));

            entity.Property(e => e.BypassPaymentStatusId).HasDefaultValue(1);
            entity.Property(e => e.IsDiscountRain).HasComment("null = ไม่มีส่วนลด | 1 = บันทึกส่วนลดฝนตก | 2 = บันทึกส่วนลดฝนตก (free day)");
            entity.Property(e => e.IsDiscountRain_FreeDay).HasComment("null = ไม่มีส่วนลด | 1 = บันทึกส่วนลดฝนตก | 2 = บันทึกส่วนลดฝนตก (free day)");
            entity.Property(e => e.RcptType).HasDefaultValue(4);
            entity.Property(e => e.isUseGoPoint).HasDefaultValue(0);

            entity.HasOne(d => d.BypassPaymentStatus).WithMany(p => p.Transactions).HasConstraintName("FK_Transaction_BypassPaymentStatus");

            entity.HasOne(d => d.CancelStaffUser).WithMany(p => p.TransactionCancelStaffUsers).HasConstraintName("FK_Transaction_StaffUser1");

            entity.HasOne(d => d.ChangeElecStaffUser).WithMany(p => p.TransactionChangeElecStaffUsers).HasConstraintName("FK_Transaction_StaffUser2");

            entity.HasOne(d => d.ChangeLogeStaffUser).WithMany(p => p.TransactionChangeLogeStaffUsers).HasConstraintName("FK_Transaction_StaffUser3");

            entity.HasOne(d => d.ChangeReservationSubZone).WithMany(p => p.TransactionChangeReservationSubZones).HasConstraintName("FK_Transaction_SubZone1");

            entity.HasOne(d => d.Loge).WithMany(p => p.Transactions).HasConstraintName("FK_Transaction_Loge");

            entity.HasOne(d => d.Member).WithMany(p => p.Transactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transaction_Member");

            entity.HasOne(d => d.PaymentGateway).WithMany(p => p.Transactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transaction_PaymentGateway");

            entity.HasOne(d => d.PaymentType).WithMany(p => p.Transactions).HasConstraintName("FK_Transaction_PaymentType");

            entity.HasOne(d => d.RcptTypeNavigation).WithMany(p => p.Transactions).HasConstraintName("FK_Transaction_ReceiptType");

            entity.HasOne(d => d.ReservationLogeElectricityType).WithMany(p => p.Transactions).HasConstraintName("FK_Transaction_ReservationLogeElectricityType");

            entity.HasOne(d => d.ReservationLogeElectronicType).WithMany(p => p.Transactions).HasConstraintName("FK_Transaction_ReservationLogeElectronicType");

            entity.HasOne(d => d.ReservationLoge).WithMany(p => p.Transactions).HasConstraintName("FK_Transaction_ReservationLoge");

            entity.HasOne(d => d.ReservationLogeType).WithMany(p => p.Transactions).HasConstraintName("FK_Transaction_ReservationLogeType");

            entity.HasOne(d => d.ReservationSubZone).WithMany(p => p.TransactionReservationSubZones).HasConstraintName("FK_Transaction_SubZone");

            entity.HasOne(d => d.StaffUser).WithMany(p => p.TransactionStaffUsers).HasConstraintName("FK_Transaction_StaffUser");

            entity.HasOne(d => d.TransactionStatus).WithMany(p => p.Transactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transaction_TransactionStatus");

            entity.HasOne(d => d.TransactionType).WithMany(p => p.Transactions).HasConstraintName("FK_Transaction_TransactionType");
        });

        modelBuilder.Entity<TransactionCancel>(entity =>
        {
            entity.Property(e => e.TranId).ValueGeneratedNever();

            entity.HasOne(d => d.Member).WithMany(p => p.TransactionCancels)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionCancel_Member");

            entity.HasOne(d => d.ReservationSubZone).WithMany(p => p.TransactionCancels).HasConstraintName("FK_TransactionCancel_SubZone");

            entity.HasOne(d => d.Tran).WithOne(p => p.TransactionCancel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionCancel_Transaction");

            entity.HasOne(d => d.TransactionStatus).WithMany(p => p.TransactionCancels)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionCancel_TransactionStatus");
        });

        modelBuilder.Entity<TransactionDetail>(entity =>
        {
            entity.HasKey(e => new { e.TransactionId, e.PaymentGatewayMethodId, e.Seq }).HasName("PK_TransactionDetail_1");

            entity.Property(e => e.Seq).ValueGeneratedOnAdd();

            entity.HasOne(d => d.PaymentGatewayMethod).WithMany(p => p.TransactionDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionDetail_PaymentGatewayMethod");

            entity.HasOne(d => d.Transaction).WithMany(p => p.TransactionDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionDetail_Transaction");
        });

        modelBuilder.Entity<TransactionDetail_Backup>(entity =>
        {
            entity.HasOne(d => d.PaymentGatewayMethod).WithMany(p => p.TransactionDetail_Backups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionDetail_Backup_PaymentGatewayMethod");
        });

        modelBuilder.Entity<TransactionDiscount>(entity =>
        {
            entity.HasOne(d => d.DiscountType).WithMany(p => p.TransactionDiscounts).HasConstraintName("FK_TransactionDiscount_DiscountType");
        });

        modelBuilder.Entity<TransactionRefund>(entity =>
        {
            entity.Property(e => e.TransactionId).ValueGeneratedNever();
        });

        modelBuilder.Entity<TransactionSGPromotion>(entity =>
        {
            entity.HasOne(d => d.SGPromotion).WithMany(p => p.TransactionSGPromotions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionSGPromotion_SGPromotion");
        });

        modelBuilder.Entity<TransactionStaff>(entity =>
        {
            entity.Property(e => e.TransactionId).ValueGeneratedNever();
        });

        modelBuilder.Entity<TransactionTaxRcpt>(entity =>
        {
            entity.HasKey(e => new { e.TransactionTaxRcptSetId, e.TranId }).HasName("PK_TransactionTaxRcpts_1");

            entity.HasOne(d => d.Tran).WithMany(p => p.TransactionTaxRcpts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionTaxRcpts_Transaction");
        });

        modelBuilder.Entity<Transaction_Backup>(entity =>
        {
            entity.Property(e => e.TranId).ValueGeneratedNever();
            entity.Property(e => e.BypassPaymentStatusId).HasDefaultValue(1);
            entity.Property(e => e.IsDiscountRain).HasComment("null = ไม่มีส่วนลด | 1 = บันทึกส่วนลดฝนตก | 2 = บันทึกส่วนลดฝนตก (free day)");
            entity.Property(e => e.IsDiscountRain_FreeDay).HasComment("null = ไม่มีส่วนลด | 1 = บันทึกส่วนลดฝนตก | 2 = บันทึกส่วนลดฝนตก (free day)");
            entity.Property(e => e.RcptType).HasDefaultValue(4);

            entity.HasOne(d => d.CancelStaffUser).WithMany(p => p.Transaction_BackupCancelStaffUsers).HasConstraintName("FK_Transaction_Backup_StaffUser1");

            entity.HasOne(d => d.ChangeElecStaffUser).WithMany(p => p.Transaction_BackupChangeElecStaffUsers).HasConstraintName("FK_Transaction_Backup_StaffUser2");

            entity.HasOne(d => d.ChangeLogeStaffUser).WithMany(p => p.Transaction_BackupChangeLogeStaffUsers).HasConstraintName("FK_Transaction_Backup_StaffUser3");

            entity.HasOne(d => d.ChangeReservationSubZone).WithMany(p => p.Transaction_BackupChangeReservationSubZones).HasConstraintName("FK_Transaction_Backup_SubZone1");

            entity.HasOne(d => d.Member).WithMany(p => p.Transaction_Backups).HasConstraintName("FK_Transaction_Backup_Member");

            entity.HasOne(d => d.PaymentGateway).WithMany(p => p.Transaction_Backups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transaction_Backup_PaymentGateway");

            entity.HasOne(d => d.PaymentType).WithMany(p => p.Transaction_Backups).HasConstraintName("FK_Transaction_Backup_PaymentType");

            entity.HasOne(d => d.RcptTypeNavigation).WithMany(p => p.Transaction_Backups).HasConstraintName("FK_Transaction_Backup_ReceiptType");

            entity.HasOne(d => d.ReservationLogeElectricityType).WithMany(p => p.Transaction_Backups).HasConstraintName("FK_Transaction_Backup_ReservationLogeElectricityType");

            entity.HasOne(d => d.ReservationLogeElectronicType).WithMany(p => p.Transaction_Backups).HasConstraintName("FK_Transaction_Backup_ReservationLogeElectronicType");

            entity.HasOne(d => d.ReservationLogeType).WithMany(p => p.Transaction_Backups).HasConstraintName("FK_Transaction_Backup_ReservationLogeType");

            entity.HasOne(d => d.ReservationSubZone).WithMany(p => p.Transaction_BackupReservationSubZones).HasConstraintName("FK_Transaction_Backup_SubZone");

            entity.HasOne(d => d.StaffUser).WithMany(p => p.Transaction_BackupStaffUsers).HasConstraintName("FK_Transaction_Backup_StaffUser");

            entity.HasOne(d => d.TransactionStatus).WithMany(p => p.Transaction_Backups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transaction_Backup_TransactionStatus");

            entity.HasOne(d => d.TransactionType).WithMany(p => p.Transaction_Backups).HasConstraintName("FK_Transaction_Backup_TransactionType");
        });

        modelBuilder.Entity<UserRoleRight>(entity =>
        {
            entity.HasOne(d => d.Right).WithMany(p => p.UserRoleRights)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRoleRight_Right");

            entity.HasOne(d => d.UserRole).WithMany(p => p.UserRoleRights)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRoleRight_UserRole");
        });

        modelBuilder.Entity<Valve>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ValveMember>(entity =>
        {
            entity.Property(e => e.MemberId).ValueGeneratedNever();
        });

        modelBuilder.Entity<VatReportRun>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<View_1>(entity =>
        {
            entity.ToView("View_1");
        });

        modelBuilder.Entity<View_MUSavingBalanceMonthly>(entity =>
        {
            entity.ToView("View_MUSavingBalanceMonthly");
        });

        modelBuilder.Entity<View_MUSavingBalanceMonthly_ALL>(entity =>
        {
            entity.ToView("View_MUSavingBalanceMonthly_ALL");
        });

        modelBuilder.Entity<View_MemberPointBalanceMonthly>(entity =>
        {
            entity.ToView("View_MemberPointBalanceMonthly");
        });

        modelBuilder.Entity<View_WalletBalanceMonthly>(entity =>
        {
            entity.ToView("View_WalletBalanceMonthly");
        });

        modelBuilder.Entity<View_WalletBalanceMonthly_ALL>(entity =>
        {
            entity.ToView("View_WalletBalanceMonthly_ALL");
        });

        modelBuilder.Entity<View_WalletLog_Union_WalletLogBackup>(entity =>
        {
            entity.ToView("View_WalletLog_Union_WalletLogBackup");
        });

        modelBuilder.Entity<View_ตรวจสอบ_ReturnError555>(entity =>
        {
            entity.ToView("View_ตรวจสอบ_ReturnError555");
        });

        modelBuilder.Entity<VipCondition>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.VipConditions).HasConstraintName("FK_VipCondition_Member");

            entity.HasOne(d => d.Zone).WithMany(p => p.VipConditions).HasConstraintName("FK_VipCondition_Zone");
        });

        modelBuilder.Entity<VisibleButton_Seller>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_VisableButton_Seller");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<VisibleZonePrice>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Wallet>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.Wallets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Wallet_Wallet");
        });

        modelBuilder.Entity<WalletLog>(entity =>
        {
            entity.HasOne(d => d.Member).WithMany(p => p.WalletLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WalletLog_Member");

            entity.HasOne(d => d.ReservationLoge).WithMany(p => p.WalletLogs).HasConstraintName("FK_WalletLog_ReservationLoge");

            entity.HasOne(d => d.StaffUser).WithMany(p => p.WalletLogs).HasConstraintName("FK_WalletLog_StaffUser");

            entity.HasOne(d => d.Transaction).WithMany(p => p.WalletLogs).HasConstraintName("FK_WalletLog_Transaction");

            entity.HasOne(d => d.WalletLogType).WithMany(p => p.WalletLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WalletLog_WalletLogType");
        });

        modelBuilder.Entity<WalletLog_Backup>(entity =>
        {
            entity.Property(e => e.Seq).ValueGeneratedNever();
        });

        modelBuilder.Entity<WebAdminLog>(entity =>
        {
            entity.HasOne(d => d.Right).WithMany(p => p.WebAdminLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WebAdminLog_Right");

            entity.HasOne(d => d.StaffUser).WithMany(p => p.WebAdminLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WebAdminLog_StaffUser");
        });

        modelBuilder.Entity<Zone>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.UpdateByNavigation).WithMany(p => p.Zones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Zone_StaffUser");
        });

        modelBuilder.Entity<saveonGO_TransactionReturn>(entity =>
        {
            entity.HasOne(d => d.SaveoneGoMember).WithMany(p => p.saveonGO_TransactionReturns).HasConstraintName("FK_saveonGO_TransactionReturn_SaveoneGo_Member");

            entity.HasOne(d => d.Transaction).WithMany(p => p.saveonGO_TransactionReturns)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_saveonGO_TransactionReturn_Transaction");
        });

        modelBuilder.Entity<saveonGO_TransactionReturn_Backup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
