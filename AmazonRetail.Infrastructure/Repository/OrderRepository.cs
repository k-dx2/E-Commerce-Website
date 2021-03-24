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
    class OrderRepository : IOrderRepository
    {
        public Task<Order> AddAsync(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Order>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Order>> GetAsync(Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Order>> GetAsync(Expression<Func<Order, bool>> predicate = null, Func<IQueryable<Order>, IOrderedQueryable<Order>> orderBy = null, string includeString = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Order>> GetAsync(Expression<Func<Order, bool>> predicate = null, Func<IQueryable<Order>, IOrderedQueryable<Order>> orderBy = null, List<Expression<Func<Order, object>>> includes = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetOrderByNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
