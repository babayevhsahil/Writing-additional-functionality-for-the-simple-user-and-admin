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
    public class PromoteToAdminCommand
    {
        public static void Handle()
        {
            UserValidator validator = new UserValidator();

            Console.Write("Enter email: ");
            string email = Console.ReadLine()!;
            while (true)
            {
                if (validator.IsEmailExists(email))
                {
                    foreach (User user in DataContext.Users)
                    {
                        if (user.Email == email)
                        {
                            if (user.IsAdmin)
                            {
                                Console.WriteLine($"{user.Name} is already an admin!");
                                return;
                            }
                            else
                            {
                                Console.WriteLine($"{user.Name} is now an admin!");
                                return;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Email not found!");
                    break;
                }
            }

            
           

        }
    }
}
