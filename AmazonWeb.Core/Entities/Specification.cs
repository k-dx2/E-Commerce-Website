using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using AmazonWeb.Core.Entities.Base;
namespace AmazonWeb.Core.Entities
{
    public class Specification : Entity
    {   
        [Key]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
