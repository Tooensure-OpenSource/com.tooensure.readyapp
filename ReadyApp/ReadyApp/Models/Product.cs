using System;
using System.Collections.Generic;
using System.Text;

namespace ReadyApp.Models
{
    public class Product : ModelBase
    {
        public string Name { get; set; } = string.Empty;
        public List<ProductItem> ProductItems { get; set; } = new();
        public decimal Cost { get; set; }
    }
}
