using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebPage8.Models;

namespace WebPage8.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Computer> Computers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ComputerOrder> ComputerOrders { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ComputerOrder>()
                .HasOne<Computer>(ky => ky.Computer)
                .WithMany(k => k.ComputerOrders)
                .HasForeignKey(ky => ky.ComputerId);

            modelBuilder.Entity<ComputerOrder>()
                .HasOne<Order>(ky => ky.Order)
                .WithMany(y => y.ComputerOrders)
                .HasForeignKey(ky => ky.OrderId);

            modelBuilder.Entity<Review>()
                .HasOne(c => c.Computer)
                .WithMany(r => r.Reviews);

            modelBuilder.Entity<Review>()
                .HasOne(c => c.Customer)
                .WithMany(r => r.Reviews);

            modelBuilder.Entity<Computer>()
                .HasOne(c => c.Category)
                .WithMany(r => r.Computers);

            modelBuilder.Entity<Computer>()
                .HasMany(r => r.Reviews);

            modelBuilder.Entity<Customer>()
                .HasMany(r => r.Reviews);
        }


    }
}
