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
    class WishlistRpository : IWishListRepository
    {
        public Task<Wishlist> AddAsync(Wishlist entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Wishlist entity)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Wishlist>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Wishlist>> GetAsync(Expression<Func<Wishlist, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Wishlist>> GetAsync(Expression<Func<Wishlist, bool>> predicate = null, Func<IQueryable<Wishlist>, IOrderedQueryable<Wishlist>> orderBy = null, string includeString = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Wishlist>> GetAsync(Expression<Func<Wishlist, bool>> predicate = null, Func<IQueryable<Wishlist>, IOrderedQueryable<Wishlist>> orderBy = null, List<Expression<Func<Wishlist, object>>> includes = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<Wishlist> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Wishlist> GetUserNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Wishlist entity)
        {
            throw new NotImplementedException();
        }
    }
}
