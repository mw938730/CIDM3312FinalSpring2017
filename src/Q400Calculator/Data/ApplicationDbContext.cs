using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Q400Calculator.Models;

namespace Q400Calculator.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ClimbData> ClimbData { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<ClimbData>().ToTable("ClimbData");
            builder.Entity<FlapData>().ToTable("Flap5Data");
            builder.Entity<Flap10Data>().ToTable("Flap10Data");
            builder.Entity<Flap15Data>().ToTable("Flap15Data");
            builder.Entity<Landing5Data>().ToTable("Landing5Data");
            builder.Entity<Landing10Data>().ToTable("Landing10Data");
            builder.Entity<Landing15Data>().ToTable("Landing15Data");

            builder.Entity<Landing35Data>().ToTable("Landing35Data");
        }

        public DbSet<FlapData> Flap5Data { get; set; }
        public DbSet<Flap10Data> Flap10Data { get; set; }
        public DbSet<Flap15Data> Flap15Data { get; set; }
        public DbSet<Landing5Data> Landing5Data { get; set; }
        public DbSet<Landing10Data> Landing10Data { get; set; }
        public DbSet<Landing15Data> Landing15Data { get; set; }
        public DbSet<Landing35Data> Landing35Data { get; set; }
    }
}
