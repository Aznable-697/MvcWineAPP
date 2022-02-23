using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcWineAPP.Models;

namespace MvcWineAPP.Data
{
    public class WineDBContext : DbContext
    {
        public WineDBContext(DbContextOptions<WineDBContext> options) : base(options)
        {
        }

        public DbSet<Grape> Grapes { get; set; }
        public DbSet<WineType> WineType { get; set; }
        public DbSet<Wine> Wines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grape>().ToTable("Grape");
            modelBuilder.Entity<WineType>().ToTable("WineType");
            modelBuilder.Entity<Wine>().ToTable("Wine");
            
        }
        
    }
}
