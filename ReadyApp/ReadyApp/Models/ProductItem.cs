using System;
using System.Collections.Generic;
using System.Text;

namespace ReadyApp.Models
{
    public class ProductItem : ModelBase
    {
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; } = 1;
    }
}
