using Microsoft.EntityFrameworkCore;
using StroreRazorPageApp.Models;

namespace StroreRazorPageApp.Data
{
    public class EcomContext:DbContext
    {
        public EcomContext(DbContextOptions<EcomContext> options) : base(options)
        {

        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}
