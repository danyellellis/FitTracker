using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FitnessTracker.Models;

namespace FitnessTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Coach> Coaches { get; set; }
      
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole 
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN" 
                },
                new IdentityRole
                {
                    Name = "Client",
                    NormalizedName = "CLIENT"
                },
                new IdentityRole
                {
                    Name = "Coach",
                    NormalizedName = "COACH"
                }

            );
        }
        
    }
}
