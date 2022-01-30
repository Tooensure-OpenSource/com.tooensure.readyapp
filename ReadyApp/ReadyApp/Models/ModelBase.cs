using System;
using System.Collections.Generic;
using System.Text;

namespace ReadyApp.Models
{
    /// <summary>
    /// Hold the core base functionality which is to be shared
    /// </summary>
    public abstract class ModelBase
    {
        public string Id { get; set; } = string.Empty;
    }
}
