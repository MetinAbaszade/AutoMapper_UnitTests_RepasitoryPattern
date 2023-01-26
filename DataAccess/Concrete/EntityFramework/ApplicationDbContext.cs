using Microsoft.EntityFrameworkCore;
using AutoMapper_Project.Entities.Concrete;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Concrete.EntityFramework
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext()
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();


                var connectionstring = configuration.GetConnectionString("DefaultConnectionString");
                optionsBuilder.UseSqlServer(connectionstring);
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(e =>
            {
                e.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Address>(a =>
            {
                a.HasKey(a => a.Id);

                a.HasOne(a => a.Employee)
                 .WithOne(e => e.Address)
                 .HasForeignKey<Address>(a => a.EmployeeId)
                 .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
