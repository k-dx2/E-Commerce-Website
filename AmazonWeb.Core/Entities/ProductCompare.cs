using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AmazonWeb.Core.Entities
{
    public class ProductCompare
    {   
        [Key]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CompareId { get; set; }
        public Compare Compare { get; set; }
    }
}
