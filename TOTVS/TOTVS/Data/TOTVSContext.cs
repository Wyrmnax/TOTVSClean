using Microsoft.EntityFrameworkCore;
using TOTVS.Models;

namespace TOTVS.Data
{
    public class TOTVSContext : DbContext
    {
        public TOTVSContext(DbContextOptions<TOTVSContext> options) : base(options)
        {
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}