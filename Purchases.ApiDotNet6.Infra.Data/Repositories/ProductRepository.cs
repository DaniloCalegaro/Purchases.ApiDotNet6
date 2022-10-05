using Microsoft.EntityFrameworkCore;
using Purchases.ApiDotNet6.Domain.Entities;
using Purchases.ApiDotNet6.Domain.Repositories;
using Purchases.ApiDotNet6.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchases.ApiDotNet6.Infra.Data.Repositories
{
    internal class ProductRepository : IProductRepository
    {
        private readonly PurchaseDbContext _db;

        public ProductRepository(PurchaseDbContext db)
        {
            _db = db;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            _db.Products.Add(product);
            await _db.SaveChangesAsync();
            return product;
        }

        public async Task Delete(Product product)
        {
            _db.Remove(product);
            await _db.SaveChangesAsync();
        }

        public async Task EditAsync(Product product)
        {
            _db.Update(product);
            await _db.SaveChangesAsync();   
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _db.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ICollection<Product>> GetProductsAsync()
        {
            return await _db.Products.ToListAsync();
        }
    }
}
