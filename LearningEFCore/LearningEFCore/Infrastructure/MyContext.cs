using LearningEFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace LearningEFCore.Infrastructure
{
    public class MyContext: DbContext
    {
        public DbSet<Deparment> Deparment { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeDeparment> EmployeeDeparment { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyData");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(GetType()));
        }
    }
}
