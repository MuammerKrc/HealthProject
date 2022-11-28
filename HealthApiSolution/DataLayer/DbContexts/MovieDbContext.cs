using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Models;
using CoreLayer.Models.AnamnesisFormModels;
using CoreLayer.Models.BaseModels;
using CoreLayer.Models.BodyInfoModels;
using CoreLayer.Models.BuyingReportsModel;
using CoreLayer.Models.DietModels;
using CoreLayer.Models.IdentityModels;
using CoreLayer.Models.JwtModels;
using CoreLayer.Models.PackageModel;
using CoreLayer.Models.PilatesModels;
using CoreLayer.Models.RecipesModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.DbContexts
{
    public class MovieDbContext : IdentityDbContext<AppUser, AppRole, string>
    {

        public MovieDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Diet> Diets { get; set; }
        public DbSet<Pilates> Pilates { get; set; }
        public DbSet<AnamnesisForm> AnamnesisForm { get; set; }
        public DbSet<BodyInfo> BodyInfos { get; set; }
        public DbSet<BuyingReport> BuyingReports { get; set; }
        public DbSet<DietDividedIntoDays> DietDividedIntoDays { get; set; }
        public DbSet<DietWeekly> DietWeeklies { get; set; }
        public DbSet<NutritionSchedule> NutritionSchedules { get; set; }
        public DbSet<NutritionScheduleItem> NutritionScheduleItems { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<PackageItem> PackageItems { get; set; }
        public DbSet<PilatesWeekly> PilatesWeeklies { get; set; }
        public DbSet<DetoxRecipe> DetoxRecipes { get; set; }
        public DbSet<FoodRecipe> FoodRecipes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Diet>().HasOne(i => i.AnamnesisForm).WithOne(i => i.Diet)
                .HasForeignKey<AnamnesisForm>(i => i.DietId);

            builder.Entity<AppUser>().HasOne(i => i.BodyInfo).WithOne(i => i.User)
                .HasForeignKey<BodyInfo>(i => i.UserId);
            builder.Entity<AppUser>().HasOne(i => i.Diet).WithOne(i => i.User)
                .HasForeignKey<Diet>(i => i.UserId);
            builder.Entity<AppUser>().HasOne(i => i.Pilates).WithOne(i => i.User)
                .HasForeignKey<Pilates>(i => i.UserId);

            builder.Entity<DietWeekly>().HasOne(i => i.NutritionSchedule).WithOne(i => i.DietWeekly)
                .HasForeignKey<NutritionSchedule>(i => i.DietWeeklyId);

            //builder.Entity<AppUser>().HasOne(i => i.FavoriteMovies).WithOne(i => i.User)
            //    .HasForeignKey<FavoriteMovies>(i => i.UserId);

            base.OnModelCreating(builder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return base.SaveChangesAsync(cancellationToken);

        }
    }
}
