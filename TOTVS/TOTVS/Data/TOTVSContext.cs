using Microsoft.EntityFrameworkCore;
using TOTVS.Models;

namespace TOTVS.Data
{
    public class TOTVSContext : DbContext
    {
        public TOTVSContext(DbContextOptions<TOTVSContext> options) : base(options)
        {
        }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutosDoPedido> ProdutosDoPedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>().ToTable("Pedidos");
            modelBuilder.Entity<Produto>().ToTable("Produtos");
            modelBuilder.Entity<ProdutosDoPedido>().ToTable("ProdutosDoPedidos");
        }
    }
}