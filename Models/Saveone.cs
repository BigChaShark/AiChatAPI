using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models;

public partial class Saveone : DbContext
{
    public Saveone()
    {
    }

    public Saveone(DbContextOptions<Saveone> options)
        : base(options)
    {
    }

    public virtual DbSet<FoodCategory> FoodCategories { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<Musaving> Musavings { get; set; }

    public virtual DbSet<SaveoneGoFleaMarketShopType> SaveoneGoFleaMarketShopTypes { get; set; }

    public virtual DbSet<SaveoneGoMember> SaveoneGoMembers { get; set; }

    public virtual DbSet<SaveoneGoMemberFleaMarket> SaveoneGoMemberFleaMarkets { get; set; }

    public virtual DbSet<SaveoneGoMemberRobinson> SaveoneGoMemberRobinsons { get; set; }

    public virtual DbSet<SaveoneGoRanking> SaveoneGoRankings { get; set; }

    public virtual DbSet<SaveoneGoZoneMarket> SaveoneGoZoneMarkets { get; set; }

    public virtual DbSet<ScbPaymentConfirmation> ScbPaymentConfirmations { get; set; }

    public virtual DbSet<Sgsaving> Sgsavings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=147.50.166.16;Database=SaveoneKoratMarket;User Id=sa;Password=9]kfoyfgayoF8ik;Encrypt=False;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Thai_CI_AS");

        modelBuilder.Entity<FoodCategory>(entity =>
        {
            entity.ToTable("FoodCategory");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.FoodCategoryUseId).HasColumnName("FoodCategory_UseId");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(50)
                .HasColumnName("ImageURL");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.ToTable("Member");

            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.AddressNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.Box1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Box2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Box3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Box4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Box5)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.District)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EndVipZone2Date).HasColumnType("datetime");
            entity.Property(e => e.EndVipZone3Date).HasColumnType("datetime");
            entity.Property(e => e.EndVipZone5Date).HasColumnType("datetime");
            entity.Property(e => e.FacebookId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IdCard)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IdCard2)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ImageCoverShopUrl)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ImageHomeRegistrationUrl)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ImageIdCardUrl)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ImageLogoShopUrl)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ImagePersonUrl)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.InstagramId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue(1);
            entity.Property(e => e.IsAdmin).HasDefaultValue(0);
            entity.Property(e => e.IsBkk).HasColumnName("isBKK");
            entity.Property(e => e.IsDetechOneMoreIp).HasColumnName("IsDetechOneMoreIP");
            entity.Property(e => e.IsLoginOtp).HasColumnName("IsLoginOTP");
            entity.Property(e => e.IsOtpreservationLast4Idcard).HasColumnName("IsOTPReservationLast4IDCard");
            entity.Property(e => e.IsPdpa).HasColumnName("IsPDPA");
            entity.Property(e => e.IsResCon).HasDefaultValue(0);
            entity.Property(e => e.IsResConMax).HasDefaultValue(0);
            entity.Property(e => e.IsResConZone2).HasDefaultValue(0);
            entity.Property(e => e.IsShowKtb).HasColumnName("IsShowKTB");
            entity.Property(e => e.IsShowKtpregister)
                .HasDefaultValue(0)
                .HasColumnName("IsShowKTPRegister");
            entity.Property(e => e.IsShowScb).HasColumnName("IsShowSCB");
            entity.Property(e => e.IsShowScbregister)
                .HasDefaultValue(0)
                .HasColumnName("IsShowSCBRegister");
            entity.Property(e => e.IsVipstatusZone2).HasColumnName("IsVIPStatusZone2");
            entity.Property(e => e.IsVipstatusZone22).HasColumnName("IsVIPStatusZone2_2");
            entity.Property(e => e.IsVipstatusZone3).HasColumnName("IsVIPStatusZone3");
            entity.Property(e => e.IsVipstatusZone32).HasColumnName("IsVIPStatusZone3_2");
            entity.Property(e => e.IsVipstatusZone5).HasColumnName("IsVIPStatusZone5");
            entity.Property(e => e.IsVipstatusZone52).HasColumnName("IsVIPStatusZone5_2");
            entity.Property(e => e.IsVipzone1)
                .HasDefaultValue(0)
                .HasColumnName("IsVIPZone1");
            entity.Property(e => e.IsVipzone2)
                .HasDefaultValue(0)
                .HasColumnName("IsVIPZone2");
            entity.Property(e => e.IsVipzone3).HasColumnName("IsVIPZone3");
            entity.Property(e => e.IsVipzone4).HasColumnName("IsVIPZone4");
            entity.Property(e => e.IsVipzone5).HasColumnName("IsVIPZone5");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.LastedReserve).HasColumnType("datetime");
            entity.Property(e => e.LicensePlate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LockerNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LockerNo2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LockerNo3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LockerNo4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LockerNo5)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Moo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NickName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OtherImageNo).IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pin)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Postcode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Prefix)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Province)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RegisterDate).HasColumnType("datetime");
            entity.Property(e => e.Remark).IsUnicode(false);
            entity.Property(e => e.Road)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ShopName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ShopType)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ShopType1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ShopType_1");
            entity.Property(e => e.ShopType2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ShopType_2");
            entity.Property(e => e.ShopType3)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ShopType_3");
            entity.Property(e => e.Soi)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SubDistrict)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zone1).HasDefaultValue(0);
            entity.Property(e => e.Zone2).HasDefaultValue(0);
            entity.Property(e => e.Zone2Group)
                .HasDefaultValue(0)
                .HasColumnName("Zone2_Group");
            entity.Property(e => e.Zone3Group).HasColumnName("Zone3_Group");
            entity.Property(e => e.Zone5Group).HasColumnName("Zone5_Group");
        });

        modelBuilder.Entity<Musaving>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("MUSaving");

            entity.Property(e => e.BalanceAmount).HasColumnType("numeric(9, 2)");

            entity.HasOne(d => d.Member).WithMany(p => p.Musavings)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MUSaving_Member");
        });

        modelBuilder.Entity<SaveoneGoFleaMarketShopType>(entity =>
        {
            entity.ToTable("SaveoneGo_FleaMarketShopType");

            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImageUrl).IsUnicode(false);
            entity.Property(e => e.TypeName).IsUnicode(false);
        });

        modelBuilder.Entity<SaveoneGoMember>(entity =>
        {
            entity.ToTable("SaveoneGo_Member");

            entity.Property(e => e.AvgTodayScore)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Avg_todayScore");
            entity.Property(e => e.BankAccountName).IsUnicode(false);
            entity.Property(e => e.BankAccountNo)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BankCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.HasBeenOpen).HasColumnName("hasBeenOpen");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.IsFranchise).HasColumnName("isFranchise");
            entity.Property(e => e.IsNeedStorage).HasColumnName("isNeedStorage");
            entity.Property(e => e.IsShopStillOpen).HasColumnName("isShopStillOpen");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.Latitude)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LineDisplayName)
                .IsUnicode(false)
                .HasColumnName("Line_displayName");
            entity.Property(e => e.LinePictureUrl)
                .IsUnicode(false)
                .HasColumnName("Line_pictureUrl");
            entity.Property(e => e.LineStatusMessage)
                .IsUnicode(false)
                .HasColumnName("Line_statusMessage");
            entity.Property(e => e.LineUserId)
                .IsUnicode(false)
                .HasColumnName("Line_userId");
            entity.Property(e => e.Longitude)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Score).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SellingProduct).IsUnicode(false);
            entity.Property(e => e.ShopName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SocialMedia).IsUnicode(false);
            entity.Property(e => e.SocialMedia2).IsUnicode(false);
            entity.Property(e => e.SocialMedia3).IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Member).WithMany(p => p.SaveoneGoMembers)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_SaveoneGo_Member_Member");
        });

        modelBuilder.Entity<SaveoneGoMemberFleaMarket>(entity =>
        {
            entity.ToTable("SaveoneGo_Member_FleaMarket");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.SaveoneGoMemberId).HasColumnName("SaveoneGo_MemberId");
            entity.Property(e => e.Score).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SellingProduct).IsUnicode(false);
            entity.Property(e => e.ShopName)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.FleaMarketShopType).WithMany(p => p.SaveoneGoMemberFleaMarkets)
                .HasForeignKey(d => d.FleaMarketShopTypeId)
                .HasConstraintName("FK_SaveoneGo_Member_FleaMarket_SaveoneGo_FleaMarketShopType");

            entity.HasOne(d => d.SaveoneGoMember).WithMany(p => p.SaveoneGoMemberFleaMarkets)
                .HasForeignKey(d => d.SaveoneGoMemberId)
                .HasConstraintName("FK_SaveoneGo_Member_FleaMarket_SaveoneGo_Member");
        });

        modelBuilder.Entity<SaveoneGoMemberRobinson>(entity =>
        {
            entity.ToTable("SaveoneGo_MemberRobinson");

            entity.Property(e => e.Code).IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SaveoneGoMemberId).HasColumnName("SaveoneGo_MemberId");
            entity.Property(e => e.SaveoneGoZoneMarketId).HasColumnName("SaveoneGo_ZoneMarketId");
            entity.Property(e => e.Score).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SellingProduct).IsUnicode(false);
            entity.Property(e => e.ShopName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Member).WithMany(p => p.SaveoneGoMemberRobinsons)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_SaveoneGo_MemberRobinson_Member");
        });

        modelBuilder.Entity<SaveoneGoRanking>(entity =>
        {
            entity.ToTable("SaveoneGo_Ranking");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.RankName).IsUnicode(false);
            entity.Property(e => e.Remark).IsUnicode(false);
            entity.Property(e => e.SaveoneGoZoneMarketId).HasColumnName("SaveoneGo_ZoneMarketId");
        });

        modelBuilder.Entity<SaveoneGoZoneMarket>(entity =>
        {
            entity.ToTable("SaveoneGo_ZoneMarket");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.GeneralClose).HasColumnType("datetime");
            entity.Property(e => e.GeneralOpen).HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SaveoneGoMarketId).HasColumnName("SaveoneGo_MarketId");
            entity.Property(e => e.Vipclose)
                .HasColumnType("datetime")
                .HasColumnName("VIPClose");
            entity.Property(e => e.Vipopen)
                .HasColumnType("datetime")
                .HasColumnName("VIPOpen");
        });

        modelBuilder.Entity<ScbPaymentConfirmation>(entity =>
        {
            entity.ToTable("SCB_PaymentConfirmation");

            entity.Property(e => e.Amount).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.BillPaymentRef1)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BillerId).HasMaxLength(20);
            entity.Property(e => e.ConfirmId)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.PayeeAccountNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PayerAccountName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SendingBankCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TransactionDateandTime)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TransactionId)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sgsaving>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("SGSavings");

            entity.Property(e => e.BalanceAmount).HasColumnType("numeric(9, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
