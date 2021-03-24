using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AmazonWeb.Core.Entities;
using AmazonWeb.Core.Repositories.Base;

namespace AmazonWeb.Core.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        public IEnumerable<Product> GetAllProduct();
        public Product GetProduct(int id);
        public Product AddProduct(Product p);
        public void RemoveProduct(int id);
        public bool UpdateProduct(Product item);




        /*
        Task<IEnumerable<Product>> GetProductListAsync();
        Task<Product> GetProductBySlug(string slug);
        Task<IEnumerable<Product>> GetProductByNameAsync(string productName);
        Task<Product> GetProductByIdWithCategoryAsync(int productId);
        Task<IEnumerable<Product>> GetProductByCategoryAsync(int categoryId);
        */

    }
}
