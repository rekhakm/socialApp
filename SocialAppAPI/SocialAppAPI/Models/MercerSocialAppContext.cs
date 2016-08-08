using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;

namespace SocialAppAPI
{
    public partial class MercerSocialAppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=INGGNEDCW6JYX1;Database=MercerSocialApp;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppSocialAdvertisement>(entity =>
            {
                entity.HasKey(e => e.AdvertisementId)
                    .HasName("PK__AppSocia__C4C7F4CD1B0907CE");

                entity.ToTable("AppSocial_Advertisement");

                entity.Property(e => e.AdvertisementId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PostedBy).HasColumnType("numeric");

                entity.Property(e => e.PostedOn).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Status).HasDefaultValueSql("1");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.AppSocialAdvertisement)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("fk_Advertisement_Category");

                entity.HasOne(d => d.PostedByNavigation)
                    .WithMany(p => p.AppSocialAdvertisement)
                    .HasForeignKey(d => d.PostedBy)
                    .HasConstraintName("fk_Advertisement_Users");
            });

            modelBuilder.Entity<AppSocialAdvertisementCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__AppSocia__19093A0B0425A276");

                entity.ToTable("AppSocial_AdvertisementCategory");

                entity.Property(e => e.CategoryId).ValueGeneratedNever();

                entity.Property(e => e.CategoryName).HasColumnType("varchar(100)");

                entity.Property(e => e.Status).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<AppSocialAdvertisementDetail>(entity =>
            {
                entity.HasKey(e => e.DetailId)
                    .HasName("PK__AppSocia__135C316D21B6055D");

                entity.ToTable("AppSocial_AdvertisementDetail");

                entity.Property(e => e.DetailId).ValueGeneratedNever();

                entity.Property(e => e.PostedBy).HasColumnType("numeric");

                entity.Property(e => e.PostedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Advertisement)
                    .WithMany(p => p.AppSocialAdvertisementDetail)
                    .HasForeignKey(d => d.AdvertisementId)
                    .HasConstraintName("fk_AdvertisementDetail_Advertisement");

                entity.HasOne(d => d.PostedByNavigation)
                    .WithMany(p => p.AppSocialAdvertisementDetail)
                    .HasForeignKey(d => d.PostedBy)
                    .HasConstraintName("fk_AdvertisementDetail_Users");
            });

            modelBuilder.Entity<AppSocialAdvertisementResponse>(entity =>
            {
                entity.HasKey(e => e.ResponseId)
                    .HasName("PK__AppSocia__1AAA646C276EDEB3");

                entity.ToTable("AppSocial_AdvertisementResponse");

                entity.Property(e => e.ResponseId).ValueGeneratedNever();

                entity.Property(e => e.CommentedBy).HasColumnType("numeric");

                entity.Property(e => e.CommentedOn).HasColumnType("datetime");

                entity.Property(e => e.Comments).HasColumnType("varchar(500)");

                entity.HasOne(d => d.Advertisement)
                    .WithMany(p => p.AppSocialAdvertisementResponse)
                    .HasForeignKey(d => d.AdvertisementId)
                    .HasConstraintName("fk_AdvertisementResponse_Advertisement");

                entity.HasOne(d => d.CommentedByNavigation)
                    .WithMany(p => p.AppSocialAdvertisementResponse)
                    .HasForeignKey(d => d.CommentedBy)
                    .HasConstraintName("fk_AdvertisementResponse_Users");
            });

            modelBuilder.Entity<AppSocialUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__AppSocia__1788CC4C7F60ED59");

                entity.ToTable("AppSocial_Users");

                entity.Property(e => e.UserId).HasColumnType("numeric");

                entity.Property(e => e.EmailId).HasMaxLength(150);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RegisteredOn).HasColumnType("datetime");

                entity.Property(e => e.Status).HasDefaultValueSql("1");
            });
        }

        public virtual DbSet<AppSocialAdvertisement> AppSocialAdvertisement { get; set; }
        public virtual DbSet<AppSocialAdvertisementCategory> AppSocialAdvertisementCategory { get; set; }
        public virtual DbSet<AppSocialAdvertisementDetail> AppSocialAdvertisementDetail { get; set; }
        public virtual DbSet<AppSocialAdvertisementResponse> AppSocialAdvertisementResponse { get; set; }
        public virtual DbSet<AppSocialUsers> AppSocialUsers { get; set; }
    }
}