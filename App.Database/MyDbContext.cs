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

        public virtual DbSet<spCarBrand> spCarBrands { get; set; }
        public virtual DbSet<spCarModel> spCarModels { get; set; }
        public virtual DbSet<spDistrict> spDistricts { get; set; }
        public virtual DbSet<spRegion> spRegions { get; set; }
        public virtual DbSet<spRole> spRoles { get; set; }
        public virtual DbSet<spStatus> spStatuses { get; set; }
        public virtual DbSet<spUnit> spUnits { get; set; }
        public virtual DbSet<tbAlert> tbAlerts { get; set; }
        public virtual DbSet<tbCar> tbCars { get; set; }
        public virtual DbSet<tbQueueDriver> tbQueueDrivers { get; set; }
        public virtual DbSet<tbUser> tbUsers { get; set; }
        public virtual DbSet<tbUserRole> tbUserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);



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


            modelBuilder.Entity<spDistrict>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<spRegion>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<spStatus>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<spUnit>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<tbImage>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
            modelBuilder.Entity<tbQueueDriver>().Property(b => b.CreateDate).HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()").ValueGeneratedOnAdd();
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
