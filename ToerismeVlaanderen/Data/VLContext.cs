using ToerismeVlaanderen.Models;
using Microsoft.EntityFrameworkCore;

namespace ToerismeVlaanderen.Data
{
    public class VLContext : DbContext
    {
        public VLContext(DbContextOptions<VLContext> options) : base(options)
        {
        }

        public DbSet<Provincie> Provincies { get; set; }
        public DbSet<Gemeente> Gemeentes { get; set; }
        public DbSet<Activiteit> Activiteiten { get; set; }
        public DbSet<Inschrijving> Inschrijvingen { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Provincie>().ToTable("Provincie");
            modelBuilder.Entity<Gemeente>().ToTable("Gemeente");
            modelBuilder.Entity<Inschrijving>().ToTable("Activiteit");
            modelBuilder.Entity<Inschrijving>().ToTable("Inschrijving");
        }
    }
}

