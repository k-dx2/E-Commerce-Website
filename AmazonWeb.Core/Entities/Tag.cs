using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace AmazonWeb.Core.Entities
{
    public class Tag
    {   
     [Key]
     public string Name { get; set; }
    }
}
