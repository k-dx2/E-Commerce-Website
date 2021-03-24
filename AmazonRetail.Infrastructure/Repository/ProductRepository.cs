using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AmazonWeb.Core.Entities;
using AmazonWeb.Core.Repositories;
//using AmazonRetailWeb.Data;
using Microsoft.EntityFrameworkCore;
using AmazonWeb.Core.Repositories.Base;

namespace AmazonRetail.Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        //private readonly AmazonWebContext _context;

        public IEnumerable<Product> GetAllProduct()
        {
         throw new NotImplementedException();

        }
        public Product AddProduct(Product p)
        {
            throw new NotImplementedException();
        }
        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }
        public void RemoveProduct(int id)
        {
            throw new NotImplementedException();
        }
        public bool UpdateProduct(Product item)
        {
            throw new NotImplementedException();
        }





        public Task<Product> AddAsync(Product entity)
        {
            throw new NotImplementedException();
        }

       

        public Task DeleteAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Product>> GetAsync(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Product>> GetAsync(Expression<Func<Product, bool>> predicate = null, Func<IQueryable<Product>, IOrderedQueryable<Product>> orderBy = null, string includeString = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Product>> GetAsync(Expression<Func<Product, bool>> predicate = null, Func<IQueryable<Product>, IOrderedQueryable<Product>> orderBy = null, List<Expression<Func<Product, object>>> includes = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        

        

        public Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }

      
    }
}