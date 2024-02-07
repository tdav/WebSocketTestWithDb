using App.Database.Extensions;
using App.Database.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.Common;
using System.Linq;
using Toolbelt.ComponentModel.DataAnnotations;

#nullable disable

namespace App.Database
{
    public class MyDbContext : IdentityDbContext<tbUser, spRole, Guid, IdentityUserClaim<Guid>,
                                tbUserRole, IdentityUserLogin<Guid>, IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
    {

        public MyDbContext() : base() { }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        #region Declare
        public virtual DbSet<spBanner> spBanners { get; set; }
        public virtual DbSet<spCarBrand> spCarBrands { get; set; }
        public virtual DbSet<spCarModel> spCarModels { get; set; }
        public virtual DbSet<spConnectorType> SpConnectorTypes { get; set; }
        public virtual DbSet<spDistrict> spDistricts { get; set; }
        public virtual DbSet<spInternetAccessType> spInternetAccessTypes { get; set; }
        public virtual DbSet<spPaymentStatus> spPaymentStatuses { get; set; }
        public virtual DbSet<spPaymentType> spPaymentTypes { get; set; }
        public virtual DbSet<spPromoCodeType> spPromoCodeTypes { get; set; }
        public virtual DbSet<spRegion> spRegions { get; set; }
        public virtual DbSet<spRole> spRoles { get; set; }
        public virtual DbSet<spServiceType> spServiceTypes { get; set; }
        public virtual DbSet<spSmsStatus> spSmsStatuses { get; set; }
        public virtual DbSet<spStatus> spStatuses { get; set; }
        public virtual DbSet<spUnit> spUnits { get; set; }
        public virtual DbSet<tbAlert> tbAlerts { get; set; }
        public virtual DbSet<tbCar> tbCars { get; set; }
        public virtual DbSet<tbChargePoint> tbChargePoints { get; set; }
        public virtual DbSet<tbChargeTag> tbChargeTags { get; set; }
        public virtual DbSet<tbComment> tbComments { get; set; }
        public virtual DbSet<tbConnector> tbConnectors { get; set; }
        public virtual DbSet<tbConnectorStatus> tbConnectorStatuses { get; set; }
        public virtual DbSet<tbFavorite> tbFavorites { get; set; }
        public virtual DbSet<tbImage> tbImages { get; set; }
        public virtual DbSet<tbPayment> tbPayments { get; set; }
        public virtual DbSet<tbPrice> tbPrices { get; set; }
        public virtual DbSet<tbPromoCode> tbPromoCodes { get; set; }
        public virtual DbSet<tbInternetAccess> tbInternetAccesses { get; set; }
        public virtual DbSet<tbMeterValue> tbMeterValues { get; set; }
        public virtual DbSet<tbMobileAppVersion> tbMobileAppVersions { get; set; }
        public virtual DbSet<tbQueueMessage> tbQueueMessages { get; set; }
        public virtual DbSet<tbQueueDriver> tbQueueDrivers { get; set; }
        public virtual DbSet<tbSesion> tbSesions { get; set; }
        public virtual DbSet<tbSms> tbSms { get; set; }
        public virtual DbSet<tbSystemSetting> tbSystemSettings { get; set; }
        public virtual DbSet<tbTransaction> tbTransactions { get; set; }
        public virtual DbSet<tbUser> tbUsers { get; set; }
        public virtual DbSet<tbUserRole> tbUserRoles { get; set; }
        public virtual DbSet<viConnectorStatusView> viConnectorStatusViews { get; set; }
        #endregion


        public DbSet<JsonDataConnectionDescription> rpJsonDataConnections { get; set; }
        public DbSet<SqlDataConnectionDescription> rpSqlDataConnections { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region TMP

            //modelBuilder.Entity<tbChargePoint>(entity =>
            //{
            //    entity.ToTable("tb_charge_point");
            //    entity.HasIndex(e => e.ChargePointId, "ChargePoint_Identifier").IsUnique();
            //    entity.Property(e => e.ChargePointId).HasMaxLength(100);
            //    entity.Property(e => e.Comment).HasMaxLength(200);
            //    entity.Property(e => e.Name).HasMaxLength(100);
            //    entity.Property(e => e.Username).HasMaxLength(50);
            //    entity.Property(e => e.Password).HasMaxLength(50);
            //    entity.Property(e => e.ClientCertThumb).HasMaxLength(100);
            //});

            //modelBuilder.Entity<tbChargeTag>(entity =>
            //{
            //    entity.ToTable("tb_charge_tag");
            //    entity.HasKey(e => e.TagId).HasName("PK_ChargeKeys");
            //    entity.Property(e => e.TagId).HasMaxLength(50);
            //    entity.Property(e => e.ParentTagId).HasMaxLength(50);
            //    entity.Property(e => e.TagName).HasMaxLength(200);
            //});

            //modelBuilder.Entity<tbMessageLog>(entity =>
            //{
            //    entity.ToTable("tb_message_log");
            //    entity.HasKey(e => e.LogId);
            //    entity.HasIndex(e => e.LogTime, "IX_MessageLog_ChargePointId");
            //    entity.Property(e => e.ChargePointId).IsRequired().HasMaxLength(100);
            //    entity.Property(e => e.ErrorCode).HasMaxLength(100);
            //    entity.Property(e => e.Message).IsRequired().HasMaxLength(100);
            //});

            //modelBuilder.Entity<tbTransaction>(entity =>
            //{
            //    entity.ToTable("tb_transaction");
            //    entity.Property(e => e.Uid).HasMaxLength(50);
            //    entity.Property(e => e.ChargePointId).IsRequired().HasMaxLength(100);
            //    entity.Property(e => e.StartResult).HasMaxLength(100);
            //    entity.Property(e => e.StartTagId).HasMaxLength(50);
            //    entity.Property(e => e.StopReason).HasMaxLength(100);
            //    entity.Property(e => e.StopTagId).HasMaxLength(50);
            //    entity.HasOne(d => d.ChargePoint)
            //        .WithMany(p => p.Transactions)
            //        .HasForeignKey(d => d.ChargePointId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_Transactions_ChargePoint");
            //});
            #endregion

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<tbConnectorStatus>(entity => { entity.HasKey(e => new { e.ChargePointId, e.ConnectorId }); });

            modelBuilder.Entity<viConnectorStatusView>(entity =>
            {
                entity.HasNoKey();
                entity.ToView("vi_connector_status_view");
            });

            modelBuilder.Entity<tbUser>(b => { b.ToTable("sx_users"); });
            modelBuilder.Entity<spRole>(b => { b.ToTable("sx_roles"); });
            modelBuilder.Entity<IdentityUserClaim<Guid>>(b => { b.ToTable("sx_user_claims"); });
            modelBuilder.Entity<IdentityUserLogin<Guid>>(b => { b.ToTable("sx_user_logins"); });
            modelBuilder.Entity<IdentityUserToken<Guid>>(b => { b.ToTable("sx_user_tokens"); });
            modelBuilder.Entity<IdentityRoleClaim<Guid>>(b => { b.ToTable("sx_role_claims"); });
            modelBuilder.Entity<tbUserRole>(b => { b.ToTable("sx_user_roles"); });
            modelBuilder.Entity<tbUserRole>().HasKey(t => new { t.UserId, t.RoleId });
            modelBuilder.Entity<tbUserRole>().HasOne(sc => sc.User).WithMany(s => s.UserRoles).HasForeignKey(sc => sc.UserId);
            modelBuilder.Entity<tbUserRole>().HasOne(sc => sc.Role).WithMany(c => c.UserRoles).HasForeignKey(sc => sc.RoleId);


            modelBuilder.Entity<tbQueueMessage>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<spBanner>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<spConnectorType>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<spDistrict>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<spPaymentStatus>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<spPaymentType>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<spRegion>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<spSmsStatus>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<spStatus>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<spUnit>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<tbChargePoint>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<tbChargeTag>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<tbComment>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<tbConnector>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<tbFavorite>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<tbImage>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<tbPayment>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<tbQueueDriver>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<tbQueueMessage>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<tbSesion>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<tbSms>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();

            modelBuilder.Entity<tbTransaction>().Property(b => b.StartTime).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<tbUser>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();


            modelBuilder.Seed();
            modelBuilder.BuildIndexesFromAnnotations();

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

        }



        public DbConnection GetDbConnection()
        {
            return Database.GetDbConnection();
        }
    }
}
