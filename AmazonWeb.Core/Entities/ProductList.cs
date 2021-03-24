using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AmazonWeb.Core.Entities
{
    public class ProductList
    {   
        [Key]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ListId { get; set; }
        public List List { get; set; }
    }
}
