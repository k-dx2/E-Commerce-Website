using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AmazonWeb.Core.Repositories.Base;
using AmazonWeb.Core.Entities;

namespace AmazonWeb.Core.Repositories
{
    public interface IWishListRepository : IRepository<Wishlist>
    {
        Task<Wishlist> GetUserNameAsync(string userName);
    }
}
