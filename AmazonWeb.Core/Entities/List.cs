﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using AmazonWeb.Core.Entities.Base;

namespace AmazonWeb.Core.Entities
{
    public class List : Entity
    {
        [Required,StringLength(80)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageFile { get; set; }
        public List<ProductList> ProductList { get; set; } = new List<ProductList>();
    }
}
