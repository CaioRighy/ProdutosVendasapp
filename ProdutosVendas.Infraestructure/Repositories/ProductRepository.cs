using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProdutosVendas.Domain.Entities;
using ProdutosVendas.Infrastructure.Data;

namespace ProdutosVendas.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _ctx;

        public ProductRepository(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            // leitura sem rastreamento (melhor para listar)
            return await _ctx.Products.AsNoTracking().ToListAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            // FindAsync traz rastreado (bom para atualizar)
            return await _ctx.Products.FindAsync(id);
        }

        public async Task AddAsync(Product product)
        {
            await _ctx.Products.AddAsync(product);
        }

        public Task UpdateAsync(Product product)
        {
            // marca como modificado (caso venha de fora não rastreado)
            _ctx.Entry(product).State = EntityState.Modified;
            return Task.CompletedTask;
        }

        public Task DeleteAsync(Product product)
        {
            _ctx.Products.Remove(product);
            return Task.CompletedTask;
        }

        public Task<int> SaveChangesAsync()
        {
            return _ctx.SaveChangesAsync();
        }
    }
}
