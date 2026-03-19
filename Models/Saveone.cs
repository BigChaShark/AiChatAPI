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

    public virtual DbSet<Musaving> Musavings { get; set; }

    public virtual DbSet<SaveoneGoFleaMarketShopType> SaveoneGoFleaMarketShopTypes { get; set; }

    public virtual DbSet<SaveoneGoMember> SaveoneGoMembers { get; set; }

    public virtual DbSet<SaveoneGoMemberFleaMarket> SaveoneGoMemberFleaMarkets { get; set; }

    public virtual DbSet<SaveoneGoMemberRobinson> SaveoneGoMemberRobinsons { get; set; }

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

        modelBuilder.Entity<Musaving>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("MUSaving");

            entity.Property(e => e.BalanceAmount).HasColumnType("numeric(9, 2)");
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
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
