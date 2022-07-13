using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintPortal.DTO
{
    internal class UserDTO
    {
        //since some values can be null we are overriding null check
        private string? _username;
        private string? _password;
        private string? _role;
        private string? _address;

        public string? Username { get => _username; set => _username = value; }
        public string? Password { get => _password; set => _password = value; }
        public string? Role { get => _role; set => _role = value; }
        public string? Address { get => _address; set => _address = value; }
    }
}
