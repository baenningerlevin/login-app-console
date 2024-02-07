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
            string? selection = string.Empty;

            do
            {
                // Display the menu
                selection = DisplayAdminMenu(selection);

                // Perform the action
                PerformAdminAction(selection);

            } while (selection != "5");

            Console.WriteLine("\nYou have successfully logged out!");
        }

        private string DisplayAdminMenu(string? selection)
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
            bool validSelection = false;

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

            return selection;
        }

        private void PerformAdminAction(string selection)
        {
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
        }
    }
}
