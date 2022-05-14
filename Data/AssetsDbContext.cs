using System;
using System.Collections.Generic;
using AssetManager.Models;
using Microsoft.EntityFrameworkCore;

namespace AssetManager.Data
{
    public class AssetsDbContext : DbContext
    {
        public DbSet<Asset> Assets { get; set; }
        public DbSet<User> Users { get; set; }

        private List<Asset> theAssets = new List<Asset> {new Asset
                {
                    Id = 1,
                    Name = "Samsung Galaxy M11",
                    Type = "smartphone",
                    SerialNumber = "0094KC029M",
                    Manufacturer = "Samsung",
                    AcquiredOn = System.DateTime.Now,
                    CurrentUser = 1
                },
                new Asset
                {
                    Id = 2,
                    Name = "Samsung Galaxy Tab S4-A",
                    Type = "tablet",
                    SerialNumber = "099393V54VT",
                    Manufacturer = "Samsung",
                    AcquiredOn = System.DateTime.Now,
                    CurrentUser = 2
                },
                new Asset
                {
                    Id = 3,
                    Name = "Lenovo Thinkpad T480s",
                    Type = "laptop",
                    SerialNumber = "PC3029m4",
                    Manufacturer = "Lenovo",
                    AcquiredOn = System.DateTime.Now,
                    CurrentUser = 1
                },
                new Asset
                {
                    Id = 4,
                    Name = "Mac Book Pro Express",
                    Type = "laptop",
                    SerialNumber = "MC343302",
                    Manufacturer = "Apple",
                    AcquiredOn = System.DateTime.Now,
                    CurrentUser = 3
                }};

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=assets.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asset>().HasData(theAssets);

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "Tinashe Chitakunye", Department = "Infrastructure Development", UserId = Guid.NewGuid(), JoinedOn = DateTime.Now, },
                new User { Id = 2, Username = "Kimberly Manyonga", Department = "Research and Development", UserId = Guid.NewGuid(), JoinedOn = DateTime.Now } ,
                new User { Id = 3, Username = "Richard Dzingai", Department = "Digital Marketing", UserId = Guid.NewGuid(), JoinedOn = DateTime.Now }
            );




        }
    }
}