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
using CoreLayer.Models.DietModels;
using CoreLayer.Models.IdentityModels;
using CoreLayer.Models.JwtModels;
using CoreLayer.Models.PilatesModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.DbContexts
{
    public class MovieDbContext : IdentityDbContext<AppUser, AppRole, string>
    {

        public MovieDbContext(DbContextOptions options) : base(options)
        {

        }


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
