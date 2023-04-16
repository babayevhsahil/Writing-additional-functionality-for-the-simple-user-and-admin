using TaskManagement.Admin;
using TaskManagement.Client;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Common
{
    public class LoginCommand
    {
        public static void Handle() //use alias
        {
            Console.WriteLine("---------------------------");
            Console.Write("Pls enter email : ");
            string email = Console.ReadLine()!;
            Console.WriteLine("---------------------------");
            Console.Write("Pls enter password : ");
            string password = Console.ReadLine()!;
            Console.WriteLine("---------------------------");

            for (int i = 0; i < DataContext.Users.Count; i++)
            {
                User user = DataContext.Users[i];

                if (user.Email == email && user.Password == password)
                {
                    if (user.IsAdmin)
                    {
                        AdminDashboard.Introduction();
                    }
                    else
                    {
                        ClientDashboard.Introduction(user);
                    }
                }
            }
        }
    }
}
