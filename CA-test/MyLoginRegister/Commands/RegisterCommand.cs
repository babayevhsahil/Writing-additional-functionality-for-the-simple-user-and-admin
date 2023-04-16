using MyLoginRegister.Database;
using MyLoginRegister.Database.Models;
using MyLoginRegister.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLoginRegister.Commands
{
    public class RegisterCommand
    {
        public StringUtility _utility = new StringUtility();
        public void Handle(DataContext database)
        {
            string firstName = GetAndValidateFirstName();
            string lastName = GetAndValidateLastName();
            string password = GetAndValidatePassword();
            string email = GetAndValidateEmail(database._users);

            User human = new User(firstName, lastName, password, email);

            database._users.Add(human);
        }

        #region First name

        string GetAndValidateFirstName()
        {
            while (true)
            {
                Console.Write("Pls enter first name : ");
                string firstName = Console.ReadLine()!;

                if (IsValidFirstName(firstName))
                    return firstName;

                Console.WriteLine("Some information is not correnct");
            }
        }
        bool IsValidFirstName(string firstName)
        {
            int MIN_LENGTH = 3;
            int MAX_LENGTH = 30;

            return IsValidName(firstName, MIN_LENGTH, MAX_LENGTH);
        }

        #endregion

        #region Last name

        string GetAndValidateLastName()
        {
            while (true)
            {
                Console.Write("Pls enter last name : ");
                string lastName = Console.ReadLine()!;

                if (IsValidLastName(lastName))
                    return lastName;

                Console.WriteLine("Some information is not correnct");
            }
        }
        bool IsValidLastName(string lastName)
        {
            int MIN_LENGTH = 5;
            int MAX_LENGTH = 20;

            return IsValidName(lastName, MIN_LENGTH, MAX_LENGTH);
        }

        #endregion

        #region Password

        string GetAndValidatePassword()
        {
            while (true)
            {
                Console.Write("Pls enter password : ");
                string password = Console.ReadLine()!;

                Console.Write("Pls enter confirm password : ");
                string ConfirmPassword = Console.ReadLine()!;

                if (password == ConfirmPassword)
                    return password;

                Console.WriteLine("Some information is not correnct");
            }
        }


        #endregion

        #region Email

        string GetAndValidateEmail(List<User> users)
        {
            char AT_SGIN = '@';

            while (true)
            {
                Console.Write("Pls enter email : ");
                string email = Console.ReadLine()!;


                //
                //if (_utility.Contains(email, AT_SGIN) && !IsEmailExists(users, email))
                //{
                //    return email;
                //}

                // Way 2
                //bool isValidFormat = false;
                //bool isUniqe = false;
                //if (_utility.Contains(email, AT_SGIN))
                //{
                //    isValidFormat = true;
                //}
                //else
                //{
                //    isValidFormat = false;
                //    Console.WriteLine("Ensure that your email contains @ character");
                //}

                //if (!IsEmailExists(users, email))
                //{
                //    isUniqe = true;
                //}
                //else
                //{
                //    isUniqe = false;
                //    Console.WriteLine("Your email is already used in system, pls try another email");
                //}

                //if (isValidFormat && isUniqe)
                //{
                //    return email;
                //}

                // Way3 
                if (_utility.Contains(email, AT_SGIN))
                {
                    if (!IsEmailExists(users, email))
                    {
                        return email;
                    }
                    else
                    {
                        Console.WriteLine("Your email is already used in system, pls try another email");
                    }
                }
                else
                {
                    Console.WriteLine("Ensure that your email contains @ character");
                }

            }
        }

        public bool IsEmailExists(List<User> users, string email)
        {
            foreach (User user in users)
            {
                if (user._email == email)
                {
                    return true;
                }
            }
            return false;
        }


        #endregion

        #region Common

        bool IsValidName(string name, int minLength, int maxLenght)
        {
            if (!_utility.IsLengthBetween(name, minLength, maxLenght))
            {
                return false;
            }

            char firstLetter = name[0];

            if (!_utility.IsUpperLetter(firstLetter))
            {
                return false;
            }

            for (int i = 1; i < name.Length; i++)
            {
                if (_utility.IsUpperLetter(name[i]))
                {
                    return false;
                }
            }

            return true;
        }

        #endregion
    }
}
