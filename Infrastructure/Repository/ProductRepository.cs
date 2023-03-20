using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{

    public class ProductRepository : IProductRepo
    {
        private readonly StoreDbContext storeDbContext;

        public ProductRepository(StoreDbContext storeDbContext)
        {
            this.storeDbContext = storeDbContext;
        }

        public Product? GetProductDetails(int productId)
        {
            return this.storeDbContext.Products?.Find(productId);
        }

        public IReadOnlyList<Product> GetProducts()
        {
            return this.storeDbContext.Products.ToList();
        }
    }
}
