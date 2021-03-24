using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AmazonWeb.Core.Entities
{
    public class ProductWishlist
    {   
        [Key]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int WishlistId { get; set; }
        public Wishlist Wishlist { get; set; }
    }
}
