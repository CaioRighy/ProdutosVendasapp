using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ProdutosVendas.Application.Interfaces;
using ProdutosVendas.Domain.Entities;
using ProdutosVendas.Infrastructure.Repositories;

namespace ProdutosVendas.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IServiceScopeFactory _scopeFactory;

        // Agora usamos IServiceScopeFactory para criar um novo escopo por operação
        public ProductService(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }

        // Utilitário: pega um repositório novo (com DbContext novo) por método
        private IProductRepository GetRepo(out IServiceScope scope)
        {
            scope = _scopeFactory.CreateScope();
            return scope.ServiceProvider.GetRequiredService<IProductRepository>();
        }

        // ===== Regras de validação simples =====
        private static void Validate(Product p)
        {
            if (p is null) throw new ValidationException("Produto inválido.");
            if (string.IsNullOrWhiteSpace(p.Name)) throw new ValidationException("Nome é obrigatório.");
            if (p.UnitPrice < 0) throw new ValidationException("Preço inválido.");
            if (p.StockQuantity < 0) throw new ValidationException("Quantidade em estoque inválida.");
        }

        // ===== Operações =====

        public async Task<List<Product>> ListAsync()
        {
            using var scope = _scopeFactory.CreateScope();
            var repo = scope.ServiceProvider.GetRequiredService<IProductRepository>();
            return await repo.GetAllAsync();
        }

        public async Task<Product> CreateAsync(Product product)
        {
            Validate(product);

            using var scope = _scopeFactory.CreateScope();
            var repo = scope.ServiceProvider.GetRequiredService<IProductRepository>();

            await repo.AddAsync(product);
            await repo.SaveChangesAsync();
            return product;
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            Validate(product);

            using var scope = _scopeFactory.CreateScope();
            var repo = scope.ServiceProvider.GetRequiredService<IProductRepository>();

            var existing = await repo.GetByIdAsync(product.Id)
                           ?? throw new ValidationException("Produto não encontrado.");

            existing.Name = product.Name;
            existing.Barcode = product.Barcode;
            existing.UnitPrice = product.UnitPrice;
            existing.StockQuantity = product.StockQuantity;
            existing.ExpirationDate = product.ExpirationDate;

            await repo.SaveChangesAsync();
            return existing;
        }

        public async Task DeleteAsync(int id)
        {
            using var scope = _scopeFactory.CreateScope();
            var repo = scope.ServiceProvider.GetRequiredService<IProductRepository>();

            var existing = await repo.GetByIdAsync(id)
                           ?? throw new ValidationException("Produto não encontrado.");

            await repo.DeleteAsync(existing);
            await repo.SaveChangesAsync();
        }

        /// <summary>
        /// Simula (ou confirma) a venda. Se applyStockUpdate=true, dá baixa no estoque.
        /// </summary>
        public async Task<decimal> SimulateSaleAsync(int productId, int quantity, bool applyStockUpdate)
        {
            if (quantity <= 0) throw new ValidationException("Quantidade deve ser maior que zero.");

            using var scope = _scopeFactory.CreateScope();
            var repo = scope.ServiceProvider.GetRequiredService<IProductRepository>();

            var product = await repo.GetByIdAsync(productId)
                          ?? throw new ValidationException("Produto não encontrado.");

            if (applyStockUpdate && product.StockQuantity < quantity)
                throw new ValidationException("Estoque insuficiente.");

            var total = product.UnitPrice * quantity;

            if (applyStockUpdate)
            {
                product.StockQuantity -= quantity;
                await repo.SaveChangesAsync();
            }

            return total;
        }
    }
}
