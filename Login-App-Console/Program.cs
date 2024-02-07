namespace Login_App_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare objects
            User user = new User();
            Account account = new Account();

            // Load accounts
            List<Account> accounts = account.LoadAccounts();

            string selection = string.Empty;
            do
            {
                // Display the menu
                selection = DisplayMenu(selection);

                // Perform the action
                PerformAction(selection, user, account);
            } while (selection != "3");
        }

        static string DisplayMenu(string? selection)
        {
            Console.WriteLine("\n+-----------------------------------+");
            Console.WriteLine("| 1: Login                          |");
            Console.WriteLine("| 2: Register                       |");
            Console.WriteLine("| 3: Close application              |");
            Console.WriteLine("+-----------------------------------+");

            Console.Write("\nEnter your selection: ");
            selection = Console.ReadLine();

            // Validate the selection
            bool validSelection = false;

            while (!validSelection)
            {
                if (selection != "1" && selection != "2" && selection != "3")
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



        static void PerformAction(string selection, User user, Account account)
        {
            switch (selection)
            {
                case "1":
                    account.Login();
                    break;

                case "2":
                    user.Register();
                    break;
            }
        }
    }
}
