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
    public class BanUserCommand
    {
        public static void Handle()
        {
            UserValidator validator = new UserValidator();

            Console.WriteLine("Please enter the user's email:");

            string email = Console.ReadLine()!;

            if (validator.IsEmailExists(email))
            {
                foreach (User user in DataContext.Users)
                {
                    if (user.Email == email)
                    {
                        if (!user.userBanner)
                        {
                            user.userBanner = true;
                            Console.WriteLine($"{user.Name} is now banned!");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"{user.Name} is already banned!");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("Email not found in the system!");
        }
    }
}
