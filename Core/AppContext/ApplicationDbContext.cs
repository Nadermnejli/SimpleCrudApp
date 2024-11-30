using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Core.AppContext
{
    public class ApplicationDbContext : DbContext
    {
        // Define DbSet for User entity
        public DbSet<User> Users { get; set; } // Corrected property name and added getter/setter

        // Constructor (optional if using dependency injection)
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Optional: Configure the database connection here if not using dependency injection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
        }
    }
}
