﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using AmazonWeb.Core.Entities.Base;
namespace AmazonWeb.Core.Entities
{
    
    public class CartItem:Entity
    {   
       
        public int Quantity { get; set; }
        public string ImageFile { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public Product Product { get; set; }

      
    }
}
