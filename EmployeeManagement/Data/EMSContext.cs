using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Data
{
    public class EMSContext : DbContext
    {
        public EMSContext()
        {            
        }
        public EMSContext(DbContextOptions<EMSContext> options) : base(options)
        {
        }

        public DbSet<Person> Employees { get; set; }
    }
}