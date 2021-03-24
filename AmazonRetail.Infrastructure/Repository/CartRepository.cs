using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AmazonWeb.Core.Entities;
using AmazonWeb.Core.Repositories;


namespace AmazonRetail.Infrastructure.Repository
{
    class CartRepository : ICartRepository
    {
        public Task<Cart> AddAsync(Cart entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Cart entity)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Cart>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Cart>> GetAsync(Expression<Func<Cart, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Cart>> GetAsync(Expression<Func<Cart, bool>> predicate = null, Func<IQueryable<Cart>, IOrderedQueryable<Cart>> orderBy = null, string includeString = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Cart>> GetAsync(Expression<Func<Cart, bool>> predicate = null, Func<IQueryable<Cart>, IOrderedQueryable<Cart>> orderBy = null, List<Expression<Func<Cart, object>>> includes = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<Cart> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Cart> GetByUserNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Cart entity)
        {
            throw new NotImplementedException();
        }
    }
}
