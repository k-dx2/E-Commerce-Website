using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AmazonWeb.Core.Entities;
using AmazonWeb.Core.Repositories.Base;

namespace AmazonWeb.Core.Repositories
{
    public interface ICartRepository : IRepository<Cart>
    {
      //  Task<Cart> GetByUserNameAsync(string userName);
    }
}
