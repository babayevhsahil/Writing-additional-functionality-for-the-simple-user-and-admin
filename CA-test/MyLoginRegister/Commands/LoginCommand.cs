using MyLoginRegister.Database;
using MyLoginRegister.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLoginRegister.Commands
{
    public class LoginCommand
    {
        public void Handle(DataContext database)
        {
            string email = Console.ReadLine()!;
            string password = Console.ReadLine()!;

            foreach (User user in database._users)
            {
                if (user._email == email && user._password == password)
                {
                    if (user._isAdmin)
                    {
                        Console.WriteLine("Hello Dear Admin!!!");
                    }
                    else
                    {
                        Console.WriteLine($"Hello!!! {user._name} {user._lastname}");
                    }
                }
            }
        }
    }
}
