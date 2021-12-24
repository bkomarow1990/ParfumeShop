using Microsoft.EntityFrameworkCore;
using ParfumeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfumeShop.Data
{
    public class ParfumeDBContext : DbContext
    {
        public ParfumeDBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // FluentAPI...
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Parfume> Parfumes { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
