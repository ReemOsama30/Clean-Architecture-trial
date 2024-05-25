using Clean_Architecture.core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Architecture.Infrastructure.DbContext
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public DbSet<product> products { get; set; }
        public DbSet<category> categories { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<product>().HasData(
                new product { id = 1, name = "Product 1", description = "Description for Product 1", price = 10, IsDeleted = false },
                new product { id = 2, name = "Product 2", description = "Description for Product 2", price = 20, IsDeleted = false },
                new product { id = 3, name = "Product 3", description = "Description for Product 3", price = 30, IsDeleted = false }
            );
        }
    }
}
