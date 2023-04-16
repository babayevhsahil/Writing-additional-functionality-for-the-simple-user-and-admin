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
    public class RemoveUserCommand
    {
        public static void Handle()
        {
            Console.Write("Write user's email : ");
            string email = Console.ReadLine()!;

            UserValidator validator = new UserValidator();

            if (!validator.IsEmailExists(email))
            {
                Console.WriteLine("Email can not be found!");
                return;
            }

            User userToRemove = null;

            foreach (User user in DataContext.Users)
            {
                if (user.Email == email)
                {
                    userToRemove = user;
                    break;
                }
            }

            if (userToRemove == null)
            {
                Console.WriteLine("User can not be found!");
                return;
            }

            if (userToRemove.IsAdmin)
            {
                Console.WriteLine("Admin user can not be removed!");
                return;
            }

            Console.WriteLine($"{userToRemove.Name} removed!");
            DataContext.Users.Remove(userToRemove);
        }
    }
}
