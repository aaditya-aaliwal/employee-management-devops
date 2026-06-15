using System.Data.Entity;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext()
            : base("EmployeeDbConnection")
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}