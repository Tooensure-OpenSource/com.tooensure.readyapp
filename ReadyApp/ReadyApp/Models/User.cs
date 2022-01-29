using ReadyApp.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadyApp.Models
{
    public class User : ModelBase
    {
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public User(string username, string email)
        {
            Username = username;
            Email = email;
        }
    }
}
