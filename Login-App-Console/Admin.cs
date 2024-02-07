using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Login_App_Console
{
    class Admin : Account
    {
        public void AdminMenu()
        {
            string? selection;
            bool validSelection = false;

            Account account = new Account();
            User user = new User();

            do
            {
                Console.WriteLine("\n+-----------------------------------+");
                Console.WriteLine("| 1: Reset password of user-account |");
                Console.WriteLine("| 2: Edit user-account              |");
                Console.WriteLine("| 3: See logged-in users            |");
                Console.WriteLine("| 4: Delete user-account            |");
                Console.WriteLine("| 5: Log out                        |");
                Console.WriteLine("+-----------------------------------+");

                Console.Write("\nEnter your selection: ");
                selection = Console.ReadLine();

                // Validate the selection
                while (!validSelection)
                {
                    if (selection != "1" && selection != "2" && selection != "3" && selection != "4" && selection != "5")
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

                switch (selection)
                {
                    case "1":
                        
                        break;
                    case "2":
                        
                        break;
                    case "3":
                        
                        break;
                    case "4":
                        break;
                }

            } while (selection != "5");

            Console.WriteLine("\nYou have successfully logged out!");
        }
    }
}
