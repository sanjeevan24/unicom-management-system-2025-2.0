using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unicom_management_system_2025.Model
{
    internal class User
    {
        public int UserID { get; set; }         // Primary key
        public string Username { get; set; }    // Login name
        public string Password { get; set; }    // Login password (plain text)
        public string Role { get; set; }
    }
}
