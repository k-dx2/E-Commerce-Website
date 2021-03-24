using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AmazonWeb.Core.Entities
{
    public class ProductRelatedProduct
    {   
        [Key]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int RelatedProductId { get; set; }
        public Product RelatedProduct { get; set; }
    }
}
