using System;
using System.Collections.Generic;
using System.Text;

namespace ReadyApp.Models
{
    public class Business : ModelBase
    {
        public string Name { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public bool InProduction { get; set; } = false;

    }
}
