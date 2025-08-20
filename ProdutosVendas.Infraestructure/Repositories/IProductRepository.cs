using System.Collections.Generic;
using System.Threading.Tasks;
using ProdutosVendas.Domain.Entities;

namespace ProdutosVendas.Infrastructure.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int id);

        Task AddAsync(Product product);
        Task UpdateAsync(Product product);       // manter na interface (mesmo que o service não use)
        Task DeleteAsync(Product product);       // assíncrono para alinhar com o service

        Task<int> SaveChangesAsync();            // retorna linhas afetadas
    }
}
