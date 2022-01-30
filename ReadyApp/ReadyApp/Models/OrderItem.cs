using ReadyApp.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadyApp.Models
{
    public class OrderItem : ModelBase
    {
        public Product Product { get; set; } = new();
        public TransactionLevel GetTransaction { get; set; } = TransactionLevel.none;

    }
}
