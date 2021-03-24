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
    class CategoryRepository : ICategoryRepository
    {
        public Task<Category> AddAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Category>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Category>> GetAsync(Expression<Func<Category, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Category>> GetAsync(Expression<Func<Category, bool>> predicate = null, Func<IQueryable<Category>, IOrderedQueryable<Category>> orderBy = null, string includeString = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Category>> GetAsync(Expression<Func<Category, bool>> predicate = null, Func<IQueryable<Category>, IOrderedQueryable<Category>> orderBy = null, List<Expression<Func<Category, object>>> includes = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
