using Microsoft.EntityFrameworkCore;
using ProdutosVendas.Domain.Entities;

namespace ProdutosVendas.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Essa propriedade representa a tabela Produtos
        public DbSet<Product> Products => Set<Product>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(p => p.UnitPrice).HasColumnType("decimal(18,2)");

                entity.HasIndex(p => p.Barcode) // Índice único para código de barras
                      .IsUnique()
                      .HasFilter("[Barcode] IS NOT NULL");
            });
        }
    }
}
