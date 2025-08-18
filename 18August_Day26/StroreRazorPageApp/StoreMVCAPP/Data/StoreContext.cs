using Microsoft.EntityFrameworkCore;
using StoreMVCAPP.Models;

namespace StoreMVCAPP.Data
{
    public class StoreContext:DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}
