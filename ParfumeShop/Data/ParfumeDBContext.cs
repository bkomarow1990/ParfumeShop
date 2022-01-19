using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ParfumeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfumeShop.Data
{
    public class ParfumeDBContext : IdentityDbContext
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
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Parfume> Parfumes { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public new virtual DbSet<User> Users { get; set; }
    }
}
