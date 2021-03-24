using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AmazonWeb.Core.Entities;

namespace AmazonRetail.Web.Data
{
    public class AmazonRetailWebDbContext : DbContext
    {
        public AmazonRetailWebDbContext (DbContextOptions<AmazonRetailWebDbContext> options)
            : base(options)
        {
        }

        public DbSet<AmazonWeb.Core.Entities.Product> Product { get; set; }
    }
}
