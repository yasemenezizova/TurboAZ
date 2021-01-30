using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurboAz.Entitities
{
    public class TurboAzContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SAMSUNG\\SQLEXPRESS03; Initial Catalog=TurboAzNew1; Integrated Security=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CAR_BRAND>().HasMany(x => x.CAR_MODEL).WithOne(x => x.CAR_BRAND).HasForeignKey(x => x.BRAND_ID).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<GENERAL_TYPE>().HasMany(x => x.GENERAL_INFO).WithOne(x => x.GENERAL_TYPE).HasForeignKey(x => x.TYPE_ID).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<TB_ADS>().HasMany(x => x.TB_ADS_IMAGE).WithOne(x => x.TB_ADS).HasForeignKey(x => x.ADS_ID).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<CAR_BRAND>().HasMany(x => x.TB_ADS).WithOne(x => x.CAR_BRAND).HasForeignKey(x => x.Brand_ID).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<CAR_MODEL>().HasMany(x => x.TB_ADS).WithOne(x => x.CAR_MODEL).HasForeignKey(x => x.Model_ID).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<GENERAL_INFO>().HasMany(x => x.TA_BanType).WithOne(x => x.GI_BanType).HasForeignKey(x => x.Body_Type_ID).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<GENERAL_INFO>().HasMany(x => x.TA_Color).WithOne(x => x.GI_Color).HasForeignKey(x => x.Color_ID).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<GENERAL_INFO>().HasMany(x => x.TA_FuelType).WithOne(x => x.GI_FuelType).HasForeignKey(x => x.Fuel_Type_ID).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<GENERAL_INFO>().HasMany(x => x.TA_Transmission).WithOne(x => x.GI_Transmission).HasForeignKey(x => x.Transmission_ID).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<GENERAL_INFO>().HasMany(x => x.TA_Gearbox).WithOne(x => x.GI_Gearbox).HasForeignKey(x => x.Gearbox_ID).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<GENERAL_INFO>().HasMany(x => x.TA_City).WithOne(x => x.GI_City).HasForeignKey(x => x.CITY_ID).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<GENERAL_INFO>().HasMany(x => x.TA_Currency).WithOne(x => x.GI_Currency).HasForeignKey(x => x.Currency_ID).OnDelete(DeleteBehavior.Restrict);
        }
        public DbSet<CAR_BRAND> CAR_BRAND { get; set; }
        public DbSet<CAR_MODEL> CAR_MODEL { get; set; }
        public DbSet<GENERAL_TYPE> GENERAL_TYPE { get; set; }
        public DbSet<GENERAL_INFO> GENERAL_INFO { get; set; }
        public DbSet<TB_ADS> TB_ADS { get; set; }
        public DbSet<TB_ADS_IMAGE> TB_ADS_IMAGE { get; set; }
    }
}
