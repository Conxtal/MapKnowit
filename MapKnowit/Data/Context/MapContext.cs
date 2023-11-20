using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using MapIt.Data.Model;


namespace MapIt.Data.Context
{
    public class MapContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=MapIt;TrustServerCertificate=true; Uid=MapitUser;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.CompanyID)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyName)
                .HasColumnName("Name");

                entity.Property(e => e.DivisionId);
                entity.HasKey(e => e.CompanyID);
                

            });
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Division> Divisions { get; set; }
    }
}
