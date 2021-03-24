using System;
using System.Collections.Generic;
using System.Text;
using AmazonWeb.Core.Entities;
using System.Threading.Tasks;
using AmazonWeb.Core.Repositories.Base;

namespace AmazonWeb.Core.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
     //Task<Category> GetCategoryWithProductsAsync(int categoryId);
    }
}
