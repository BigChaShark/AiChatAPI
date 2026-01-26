using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("StaffUser")]
public partial class StaffUser
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UserName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Password { get; set; }

    public int UserLevelId { get; set; }

    public int? StaffId { get; set; }

    public int Status { get; set; }

    public int UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdate { get; set; }

    public long? UserRoleId { get; set; }

    [InverseProperty("StaffUser")]
    public virtual ICollection<ATKResultRecord> ATKResultRecordStaffUsers { get; set; } = new List<ATKResultRecord>();

    [InverseProperty("UpdateStaffUser")]
    public virtual ICollection<ATKResultRecord> ATKResultRecordUpdateStaffUsers { get; set; } = new List<ATKResultRecord>();

    [InverseProperty("StaffUser")]
    public virtual ICollection<AdvanceReservationStatus> AdvanceReservationStatuses { get; set; } = new List<AdvanceReservationStatus>();

    [InverseProperty("StaffUser")]
    public virtual ICollection<AdvanceReservation> AdvanceReservations { get; set; } = new List<AdvanceReservation>();

    [InverseProperty("StaffUser")]
    public virtual ICollection<AppAnnounce> AppAnnounces { get; set; } = new List<AppAnnounce>();

    [InverseProperty("UpdateByNavigation")]
    public virtual ICollection<AppImage> AppImages { get; set; } = new List<AppImage>();

    [InverseProperty("StaffUser")]
    public virtual ICollection<Bank_Sattlement> Bank_Sattlements { get; set; } = new List<Bank_Sattlement>();

    [InverseProperty("CancelByNavigation")]
    public virtual ICollection<DiscountRain_PaymentGateway> DiscountRain_PaymentGatewayCancelByNavigations { get; set; } = new List<DiscountRain_PaymentGateway>();

    [InverseProperty("CreateByNavigation")]
    public virtual ICollection<DiscountRain_PaymentGateway> DiscountRain_PaymentGatewayCreateByNavigations { get; set; } = new List<DiscountRain_PaymentGateway>();

    [InverseProperty("UpdateByNavigation")]
    public virtual ICollection<StaffUser> InverseUpdateByNavigation { get; set; } = new List<StaffUser>();

    [InverseProperty("StaffUser")]
    public virtual ICollection<KitchenWalletLog> KitchenWalletLogs { get; set; } = new List<KitchenWalletLog>();

    [InverseProperty("UpdateByNavigation")]
    public virtual ICollection<LogeGroup> LogeGroups { get; set; } = new List<LogeGroup>();

    [InverseProperty("UpdateByNavigation")]
    public virtual ICollection<Loge> Loges { get; set; } = new List<Loge>();

    [InverseProperty("CreateByNavigation")]
    public virtual ICollection<MP_Member> MP_Members { get; set; } = new List<MP_Member>();

    [InverseProperty("CreateByNavigation")]
    public virtual ICollection<MP_Transaction> MP_Transactions { get; set; } = new List<MP_Transaction>();

    [InverseProperty("StaffUser")]
    public virtual ICollection<MUSavingLog> MUSavingLogs { get; set; } = new List<MUSavingLog>();

    [InverseProperty("StaffUser")]
    public virtual ICollection<MemberPointLog> MemberPointLogs { get; set; } = new List<MemberPointLog>();

    [InverseProperty("UpdateByNavigation")]
    public virtual ICollection<MenuCategory> MenuCategories { get; set; } = new List<MenuCategory>();

    [InverseProperty("UpdateByNavigation")]
    public virtual ICollection<MerchantCategory> MerchantCategories { get; set; } = new List<MerchantCategory>();

    [InverseProperty("UpdateByNavigation")]
    public virtual ICollection<OpenTimeZone> OpenTimeZones { get; set; } = new List<OpenTimeZone>();

    [InverseProperty("UpdateByNavigation")]
    public virtual ICollection<OutStandingDebtLog> OutStandingDebtLogs { get; set; } = new List<OutStandingDebtLog>();

    [InverseProperty("CreateByNavigation")]
    public virtual ICollection<Payin> PayinCreateByNavigations { get; set; } = new List<Payin>();

    [InverseProperty("LastUpdateByNavigation")]
    public virtual ICollection<Payin> PayinLastUpdateByNavigations { get; set; } = new List<Payin>();

    [InverseProperty("StaffUser")]
    public virtual ICollection<QueueSMSSending> QueueSMSSendings { get; set; } = new List<QueueSMSSending>();

    [InverseProperty("CreateByNavigation")]
    public virtual ICollection<ReceiptLog> ReceiptLogs { get; set; } = new List<ReceiptLog>();

    [InverseProperty("CreateByNavigation")]
    public virtual ICollection<ReprintLog> ReprintLogs { get; set; } = new List<ReprintLog>();

    [InverseProperty("UpdateByNavigation")]
    public virtual ICollection<ReservationLogeAdditional_Backup> ReservationLogeAdditional_Backups { get; set; } = new List<ReservationLogeAdditional_Backup>();

    [InverseProperty("UpdateByNavigation")]
    public virtual ICollection<ReservationLogeAdditional> ReservationLogeAdditionals { get; set; } = new List<ReservationLogeAdditional>();

    [InverseProperty("StaffUser")]
    public virtual ICollection<SGPointLog> SGPointLogs { get; set; } = new List<SGPointLog>();

    [InverseProperty("StaffUser")]
    public virtual ICollection<SGSavingLog> SGSavingLogs { get; set; } = new List<SGSavingLog>();

    [InverseProperty("StaffUser")]
    public virtual ICollection<SaveoneGo_MemberStamp> SaveoneGo_MemberStamps { get; set; } = new List<SaveoneGo_MemberStamp>();

    [InverseProperty("ReceiveByNavigation")]
    public virtual ICollection<SavingReceive> SavingReceives { get; set; } = new List<SavingReceive>();

    [InverseProperty("UpdateByNavigation")]
    public virtual ICollection<SkipOTP> SkipOTPs { get; set; } = new List<SkipOTP>();

    [InverseProperty("UpdateByNavigation")]
    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();

    [ForeignKey("StaffId")]
    [InverseProperty("StaffUsers")]
    public virtual Staff? StaffNavigation { get; set; }

    [InverseProperty("StaffUser")]
    public virtual ICollection<StaffUserRight> StaffUserRights { get; set; } = new List<StaffUserRight>();

    [InverseProperty("CancelStaffUser")]
    public virtual ICollection<Transaction> TransactionCancelStaffUsers { get; set; } = new List<Transaction>();

    [InverseProperty("ChangeElecStaffUser")]
    public virtual ICollection<Transaction> TransactionChangeElecStaffUsers { get; set; } = new List<Transaction>();

    [InverseProperty("ChangeLogeStaffUser")]
    public virtual ICollection<Transaction> TransactionChangeLogeStaffUsers { get; set; } = new List<Transaction>();

    [InverseProperty("StaffUser")]
    public virtual ICollection<Transaction> TransactionStaffUsers { get; set; } = new List<Transaction>();

    [InverseProperty("CancelStaffUser")]
    public virtual ICollection<Transaction_Backup> Transaction_BackupCancelStaffUsers { get; set; } = new List<Transaction_Backup>();

    [InverseProperty("ChangeElecStaffUser")]
    public virtual ICollection<Transaction_Backup> Transaction_BackupChangeElecStaffUsers { get; set; } = new List<Transaction_Backup>();

    [InverseProperty("ChangeLogeStaffUser")]
    public virtual ICollection<Transaction_Backup> Transaction_BackupChangeLogeStaffUsers { get; set; } = new List<Transaction_Backup>();

    [InverseProperty("StaffUser")]
    public virtual ICollection<Transaction_Backup> Transaction_BackupStaffUsers { get; set; } = new List<Transaction_Backup>();

    [ForeignKey("UpdateBy")]
    [InverseProperty("InverseUpdateByNavigation")]
    public virtual StaffUser UpdateByNavigation { get; set; } = null!;

    [ForeignKey("UserLevelId")]
    [InverseProperty("StaffUsers")]
    public virtual UserLevel UserLevel { get; set; } = null!;

    [InverseProperty("StaffUser")]
    public virtual ICollection<WalletLog> WalletLogs { get; set; } = new List<WalletLog>();

    [InverseProperty("StaffUser")]
    public virtual ICollection<WebAdminLog> WebAdminLogs { get; set; } = new List<WebAdminLog>();

    [InverseProperty("UpdateByNavigation")]
    public virtual ICollection<Zone> Zones { get; set; } = new List<Zone>();
}
