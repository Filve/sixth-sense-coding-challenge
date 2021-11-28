using Microsoft.EntityFrameworkCore;
using sixth.sense.api.Models;

namespace sixth.sense.api.Data
{
    public class SixthSenseDbContext : DbContext
    {
        public SixthSenseDbContext(DbContextOptions<SixthSenseDbContext> options) : base(options)
        {

        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
