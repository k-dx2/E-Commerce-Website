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
    class CompareRepository : ICompareRepository
    {
        public Task<Compare> AddAsync(Compare entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Compare entity)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Compare>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Compare>> GetAsync(Expression<Func<Compare, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Compare>> GetAsync(Expression<Func<Compare, bool>> predicate = null, Func<IQueryable<Compare>, IOrderedQueryable<Compare>> orderBy = null, string includeString = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Compare>> GetAsync(Expression<Func<Compare, bool>> predicate = null, Func<IQueryable<Compare>, IOrderedQueryable<Compare>> orderBy = null, List<Expression<Func<Compare, object>>> includes = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<Compare> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Compare> GetByUserNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Compare entity)
        {
            throw new NotImplementedException();
        }
    }
}
