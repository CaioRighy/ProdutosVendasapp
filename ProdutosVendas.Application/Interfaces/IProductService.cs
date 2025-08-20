using ProdutosVendas.Domain.Entities;

namespace ProdutosVendas.Application.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> ListAsync();
        Task<Product> CreateAsync(Product product);
        Task<Product> UpdateAsync(Product product);
        Task DeleteAsync(int id);
        Task<decimal> SimulateSaleAsync(int productId, int quantity, bool applyStockUpdate);
    }
}
