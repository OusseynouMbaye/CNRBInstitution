using CNRBInstitution.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CNRBInstitution.Infrastructure.Context
{
    public class CnrbInstitutionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;

        public CnrbInstitutionContext(DbContextOptions<CnrbInstitutionContext> options) : base(options)
        {
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasKey(e => e.EmployeeId);
            modelBuilder.Entity<Country>().HasKey(c => c.CountryId);
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee("John", "Doe") { EmployeeId = 1, },
                new Employee("Jane", "Lane") { EmployeeId = 2, }
                );
            modelBuilder.Entity<Country>().HasData(
                new Country("Nigeria") { CountryId = 1, },
                new Country("Ghana") { CountryId = 2, }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
