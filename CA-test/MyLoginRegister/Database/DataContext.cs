using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLoginRegister.Database.Models;

namespace MyLoginRegister.Database
{
    public class DataContext
    {
        public List<User> _users = new List<User>();

        public DataContext()
        {
            AddUserSeedings();
        }

        public void AddUserSeedings()
        {
            _users.Add(new User("Super", "Admin", "123321", "admin@gmail.com", true));
        }
    }

}
