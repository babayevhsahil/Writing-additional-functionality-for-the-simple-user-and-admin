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
    public class UpdateSettingsCommand
    {
        public static void Handle()
        {
            Console.Write("Enter the ID of the user to update: ");
            int userId = int.Parse(Console.ReadLine()!);
            User userToUpdate = null;
        
                foreach (User user in DataContext.Users)
                {
                    if (user.Id == userId)
                    {
                        userToUpdate = user;
                        break;
                    }
                }

                if (userToUpdate == null)
                {
                    Console.WriteLine("User not found");
                    return;
                }

                Console.Write("Enter the new name of the user: ");
                string newName = Console.ReadLine()!;
                userToUpdate.Name = newName;

                Console.Write("Enter the new last name of the user: ");
                string newLastName = Console.ReadLine()!;
                userToUpdate.LastName = newLastName;

                Console.Write("Enter the new password of the user: ");
                string newPassword = Console.ReadLine()!;
                userToUpdate.Password = newPassword;

                Console.WriteLine("User's data has been updated!");
        }
    }
}
