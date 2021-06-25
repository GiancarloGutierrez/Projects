using System;
using System.Collections.Generic;

namespace Giancarlo_Gutierrez_A1.Models
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime Birthday { get; set; }
        public string Password { get; set; }
    }
}
