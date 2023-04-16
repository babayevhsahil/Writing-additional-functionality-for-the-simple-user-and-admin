using MyLoginRegister.Commands;
using MyLoginRegister.Database;
using MyLoginRegister.Utilities;

namespace MyLoginRegister
{

    internal class Program
    {
        static void Main(string[] args)
        {
            StringUtility stringUtility = new StringUtility();

            DataContext database = new DataContext();

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("/register");
                Console.WriteLine("/login");
                Console.WriteLine("/exit");
                Console.WriteLine("");

                Console.Write("Pls select command : ");
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "/register":
                        RegisterCommand registerCommand = new RegisterCommand();
                        registerCommand.Handle(database);
                        break;
                    case "/login":
                        LoginCommand loginCommand = new LoginCommand();
                        loginCommand.Handle(database);
                        break;
                    case "/exit":
                        Console.WriteLine("Bye-Bye");
                        return;
                    default:
                        Console.WriteLine("Invalid Command, Please try again");
                        break;
                }

            }

        }
    }

}