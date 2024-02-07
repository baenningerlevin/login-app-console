namespace Login_App_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Account account = new Account();

            bool validSelection = false;
            string? selection;

            // Create the file if it doesn't exist
            string relativePathDir = @"..\..\..\Data\";
            string relativePathFile = @"..\..\..\Data\Accounts.txt";

            if (!File.Exists(relativePathFile))
            {
                Directory.CreateDirectory(relativePathDir);
                File.Create(relativePathFile);
            }

            // Create a list of accounts
            List<Account> accounts = new List<Account>();

            var lines = File.ReadAllLines(relativePathFile);
            foreach (string line in lines)
            {
                var values = line.Split(',');
                accounts.Add(new Account { Username = values[0], Password = values[1], Role = values[2] });
            }

            // Display the menu
            do
            {
                Console.WriteLine("\n+-----------------------------------+");
                Console.WriteLine("| 1: Login                          |");
                Console.WriteLine("| 2: Register                       |");
                Console.WriteLine("| 3: Close application              |");
                Console.WriteLine("+-----------------------------------+");

                Console.Write("\nEnter your selection: ");
                selection = Console.ReadLine();

                // Validate the selection
                while (!validSelection)
                {
                    if (selection != "1" && selection != "2" && selection != "3" && selection != "52")
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

                // Perform the action
                switch (selection)
                {
                    case "1":
                        account.Login();
                        break;

                    case "2":
                        user.Register();
                        break;

                    case "52":
                        Console.WriteLine("\nHello there, I'm BATMAN!");
                        break;
                }
            } while (selection != "3");

            Environment.Exit(0);
        }
    }
}
