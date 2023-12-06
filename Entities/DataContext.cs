using Microsoft.EntityFrameworkCore;
namespace Exam.Entities
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<departmen> Departmens { get; set; }
        public DbSet<employees> Employees { get; set; }
    }
}
