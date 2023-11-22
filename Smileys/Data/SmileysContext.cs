using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Smileys.Models;

namespace Smileys.Data
{
    public class SmileysContext : DbContext
    {
        public SmileysContext (DbContextOptions<SmileysContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure unique constraint for CVR
            modelBuilder.Entity<Company>()
                .HasIndex(c => c.CVR)
                .IsUnique();
        }

        public DbSet<Smileys.Models.Company> Company { get; set; } = default!;
    }
}
