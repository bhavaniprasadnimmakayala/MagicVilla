using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.DTO;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<LocalUser> LocalUsers { get; set; }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Villa>().HasData(
               new Villa
               {
                   Id = 1,
                   Name = "Royal Villa",
                   Occupancy = 4,
                   Place = "Chennai"
               },
              new Villa
              {
                  Id = 2,
                  Name = "Premium Pool Villa",
                  Occupancy = 4,
                  Place = "Hyderabad"
              },
              new Villa
              {
                  Id = 3,
                  Name = "Luxury Pool Villa",
                  Occupancy = 4,
                  Place = "Chitoor"
              });
        }


    }
}
