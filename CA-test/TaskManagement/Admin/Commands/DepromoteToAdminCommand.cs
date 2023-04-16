using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class DepromoteToAdminCommand
    {
        public static void Handle()
        {
            UserValidator validator = new UserValidator();
            string email = Console.ReadLine()!;
            
            while(true)
            {
                if (validator.IsEmailExists(email))
                {
                    Console.WriteLine("Email not found!");
                    return;
                }

                foreach (User user in DataContext.Users)
                {
                    if (user.Email == email)
                    {
                        if (user.IsAdmin)
                        {
                            user.IsAdmin = false;
                            Console.WriteLine($"{user.Name} is now a user.");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"{user.Name} is already a user.");
                            return;
                        }
                    }
                }

                Console.WriteLine("Email not found!");
            }
            
        }
    }
}
