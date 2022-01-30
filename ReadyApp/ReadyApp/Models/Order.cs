using ReadyApp.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadyApp.Models
{
    public class Order : ModelBase
    {
        public string? businessId { get; set; }
        public string? userId { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new();
        public decimal Cost { get; set; }

    }
}
