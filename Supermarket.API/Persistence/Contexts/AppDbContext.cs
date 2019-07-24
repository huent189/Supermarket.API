using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().ToTable("Category").HasKey(c => c.Id);
            modelBuilder.Entity<Category>().Property(c => c.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Category>().Property(c => c.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Category>().HasMany(c => c.Products).WithOne(p => p.Category).HasForeignKey(p => p.Id);

            modelBuilder.Entity<Product>().ToTable("Product").HasKey(p => p.Id);
            modelBuilder.Entity<Product>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd().HasColumnName("Id");
            modelBuilder.Entity<Product>().Property(p => p.Name).HasColumnName("Name");
            modelBuilder.Entity<Product>().Property(p => p.Unit);
            modelBuilder.Entity<Product>().Property(p => p.Quantity);
            // To use in memory database, no need to connect to a real database
            modelBuilder.Entity<Category>().HasData(
                new Category {Id = Guid.NewGuid(), Name = "Fruits and Vegetables"},
                new Category {Id = Guid.NewGuid(), Name = "Dairy"}
            );
        }
    }
}
