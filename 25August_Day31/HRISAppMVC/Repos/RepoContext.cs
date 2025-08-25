using Microsoft.EntityFrameworkCore;
using ModelsLib;

namespace Repos
{
    public class RepoContext:DbContext
    {
        public RepoContext(DbContextOptions<RepoContext> options) : base(options)
        {}

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        

    }
}
