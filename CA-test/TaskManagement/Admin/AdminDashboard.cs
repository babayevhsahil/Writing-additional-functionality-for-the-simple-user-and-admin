﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Admin.Commands;
using TaskManagement.Database;

namespace TaskManagement.Admin
{
    public class AdminDashboard
    {
        public static void Introduction()
        {
            Console.WriteLine("Hello dear admin");

            while (true)
            {
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "/message-to":
                        MessageToCommand.Handle();
                        break;
                    case "/remove-user":
                        RemoveUserCommand.Handle();
                        break;
                    case "/update-settings":
                        UpdateSettingsCommand.Handle();
                        break;
                    case "/depromote-from-admin":
                        DepromoteToAdminCommand.Handle();
                        break;
                    case "/promote-to-admin":
                        PromoteToAdminCommand.Handle();
                        break;
                    case "/show-users":
                        ShowUsersCommand.Handle();
                        break;
                    case "/show-user-by-email":
                        ShowUserByEmailCommand.Handle();
                        break;
                    case "/show-user-by-id":
                        ShowUserByIdCommand.Handle();
                        break;
                    case "/add-user":
                        AddUserCommand.Handle();
                        break;
                    case "/logout":
                        Console.WriteLine("Bye-bye");
                        return;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
                        break;
                }
            }
        }

    }
}
