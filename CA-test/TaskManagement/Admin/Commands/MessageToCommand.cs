using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common;

namespace TaskManagement.Admin.Commands
{
    public class MessageToCommand
    {
        public static void Handle()
        {
            UserValidator validator = new UserValidator();

            Console.WriteLine("Please write the recipient's email:");
            string recipientEmail = Console.ReadLine()!;

            if (!validator.IsEmailExists(recipientEmail))
            {
                Console.WriteLine("Email not found. Please try again.");
                return;
            }

            Console.WriteLine("Please write your message (minimum 10 characters):");
            string message = Console.ReadLine()!;

            if (message.Length < 10)
            {
                Console.WriteLine("Message is too short. Please try again.");
                return;
            }

            Console.WriteLine("Message sent successfully!");
        }
    }
}
