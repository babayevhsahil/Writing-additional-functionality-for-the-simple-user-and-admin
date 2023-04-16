using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLoginRegister.Database.Models
{
    public class User
    {
        public string _name;
        public string _lastname;
        public string _password;
        public string _email;
        public bool _isAdmin;

        public User(string name, string lastname, string password, string email, bool isAdmin = true)
        {
            _name = name;
            _lastname = lastname;
            _password = password;
            _email = email;
            _isAdmin = isAdmin;
        }
    }
}
