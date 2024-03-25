using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using MapIt.Data.Model;
using Microsoft.EntityFrameworkCore.Migrations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace MapIt.Data.Context
{
    public class MapContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Data Source=OSDEPF2JGAS0\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False; Initial Catalog=MapIt");
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<OwnershipType> OwnershipTypes { get; set; }
        public DbSet<CompanySiteRelation> CompanySites { get; set; }    
        public DbSet<CompanySiteActivityRelation> CompanyActivities { get; set; }
        public DbSet<CompanySiteOwnerRelation> CompanySiteOwnerRelations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.CompanyID)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyName)
                .HasColumnName("Name");

                entity.Property(e => e.DivisionID);
                entity.HasKey(e => e.CompanyID);
                

            });

        }

       

    }
}