using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Holloman_Web2Final.Models;

namespace Holloman_Web2Final.Data
{
    public class Holloman_Web2FinalDb : DbContext
    {
        public Holloman_Web2FinalDb (DbContextOptions<Holloman_Web2FinalDb> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    FirstName = "John",
                    LastName = "Smith",
                    PhoneNumber = "1234567890",
                    Email = "LotsofPizza@HungerMan.org"
                },
                new Customer
                {
                    CustomerId = 2,
                    FirstName = "Mary",
                    LastName = "Sue",
                    PhoneNumber = "5432107986",
                    Email = ""
                },
                new Customer
                {
                    CustomerId = 3,
                    FirstName = "Tim",
                    LastName = "Anderson",
                    PhoneNumber = "5550987691",
                    Email = "HiddenAgenda@YourSoulIsMine.sus"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    SerialNumber = "AF3yVUhwKD",
                    Type = "Hat",
                    Name = "Lushbun",
                    Brand = "Zuzbugger"
                },
                new Product
                {
                    ProductId = 2,
                    SerialNumber = "hbrnRb3xKP",
                    Type = "Pants",
                    Name = "Pinstripe",
                    Brand = "Zutts"
                },
                new Product
                {
                    ProductId = 3,
                    SerialNumber = "tQ9EcwJHD2",
                    Type = "Gloves",
                    Name = "Finger Hugs",
                }
                );

            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    OrderId = 1,
                    CustomerId = 1,
                    ProductId = 3,
                    OrderDate = DateTime.Now,
                    
                });
            modelBuilder.Entity<Product>().Navigation(p => p.Orders).AutoInclude();
        }

        public DbSet<Holloman_Web2Final.Models.Customer> Customer { get; set; } = default!;
        public DbSet<Holloman_Web2Final.Models.Product> Product { get; set; } = default!;
        public DbSet<Holloman_Web2Final.Models.Order> Order { get; set; } = default!;
    }
}
