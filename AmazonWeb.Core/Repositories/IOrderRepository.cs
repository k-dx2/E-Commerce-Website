using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AmazonWeb.Core.Entities;
using AmazonWeb.Core.Repositories.Base;

namespace AmazonWeb.Core.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<IEnumerable<Order>> GetOrderByNameAsync(string userName);
    }
}
