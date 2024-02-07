using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Login_App_Console
{
    class User : Account
    {
        public void Register()
        {
            Console.WriteLine("\nRegister a new user");
            Console.WriteLine("------------------------------");
            
            Console.Write("Enter username: ");
            string? username = Console.ReadLine();

            Console.Write("Enter password: ");
            string? password = Console.ReadLine();

            Validator registrationValidator = new Validator();
            registrationValidator.ValidateRegistration(username, password);
        }

        public void UserMenu()
        {
            string? selection;
            bool validSelection = false;

            Account account = new Account();
            User user = new User();

            do
            {
                Console.WriteLine("\n+-----------------------------------+");
                Console.WriteLine("|                                   |");
                Console.WriteLine("| 1: Log out                        |");
                Console.WriteLine("|                                   |");
                Console.WriteLine("+-----------------------------------+");

                Console.Write("\nEnter your selection: ");
                selection = Console.ReadLine();

                // Validate the selection
                while (!validSelection)
                {
                    if (selection != "1")
                    {
                        validSelection = false;
                        Console.Write("This is not a valid value! Enter your selection: ");
                        selection = Console.ReadLine();
                    }
                    else
                    {
                        validSelection = true;
                    }
                }

                
            } while (selection != "1");

            Console.WriteLine("\nYou have successfully logged out!");
        }
    }
}
