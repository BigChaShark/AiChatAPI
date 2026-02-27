using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models;

public partial class APIAIContext : DbContext
{
    public APIAIContext()
    {
    }

    public APIAIContext(DbContextOptions<APIAIContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AllTable> AllTables { get; set; }

    public virtual DbSet<ChatLog> ChatLogs { get; set; }

    public virtual DbSet<FoodMenuPapayaShop> FoodMenuPapayaShops { get; set; }

    public virtual DbSet<ServiceDetailZuesM> ServiceDetailZuesMs { get; set; }

    public virtual DbSet<StoreInformationPapayaShop> StoreInformationPapayaShops { get; set; }

    public virtual DbSet<StoreInformationZuesM> StoreInformationZuesMs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=BIGSHARK\\SQLEXPRESS;Database=APIAI;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AllTable>(entity =>
        {
            entity.ToTable("AllTable");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ChatLog>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("Chat_Log");

            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<FoodMenuPapayaShop>(entity =>
        {
            entity.HasKey(e => e.FoodId);

            entity.ToTable("FoodMenu_PapayaShop");

            entity.Property(e => e.FoodId).HasColumnName("FoodID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(9, 2)");
        });

        modelBuilder.Entity<ServiceDetailZuesM>(entity =>
        {
            entity.HasKey(e => e.ServiceId);

            entity.ToTable("ServiceDetail_ZuesMS");

            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(9, 2)");
        });

        modelBuilder.Entity<StoreInformationPapayaShop>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("StoreInformation_PapayaShop");

            entity.Property(e => e.CloseTime).HasPrecision(0);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LocationID");
            entity.Property(e => e.OpenTime).HasPrecision(0);
        });

        modelBuilder.Entity<StoreInformationZuesM>(entity =>
        {
            entity.HasKey(e => e.Seq);

            entity.ToTable("StoreInformation_ZuesMS");

            entity.Property(e => e.BranchName).HasMaxLength(200);
            entity.Property(e => e.CloseTime).HasPrecision(0);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LocationID");
            entity.Property(e => e.OpenTime).HasPrecision(0);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
