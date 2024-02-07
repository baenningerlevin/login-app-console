using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_App_Console
{
    class Validator
    {
        string relativePathFile = @"..\..\..\Data\Accounts.txt";

        public void ValidateRegistration(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Username and/or password are empty. Please try again.");
                User user = new User();
                user.Register();
            }
            else
            {
                var lines = File.ReadAllLines(relativePathFile);
                bool isDuplicate = false;

                foreach (string line in lines)
                {
                    var values = line.Split(',');
                    if (values[0] == username)
                    {
                        Console.WriteLine($"Your username '{username}' already exists. Please take another one.");
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    File.AppendAllText(relativePathFile, Environment.NewLine + username + ", " + password + ", User");

                    Console.WriteLine("\nYou have successfully registrated your account!");
                }
                else
                {
                    User user = new User();
                    user.Register();
                }
            }
        }

        public void ValidateLogin(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Username and/or password are empty. Please try again.");

                Account account = new Account();
                account.Login();
            }
            else
            {
                var lines = File.ReadAllLines(relativePathFile);
                bool isFound = false;

                foreach (string line in lines)
                {
                    var values = line.Split(',');
                    if (values[0].Trim() == username && values[1].Trim() == password)
                    {
                        isFound = true;
                        if (values[2].Trim() == "Admin")
                        {
                            Admin admin = new Admin();
                            admin.AdminMenu();
                        }
                        else
                        {
                            User user = new User();
                            user.UserMenu();
                        }
                        break;
                    }
                    
                }

                if (!isFound)
                {
                    Console.WriteLine("Username and/or password are incorrect. Please try again.");

                    Account account = new Account();
                    account.Login();
                }
            }   
        }

        
    }
}
