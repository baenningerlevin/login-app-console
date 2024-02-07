using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_App_Console
{
    class Account
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }

        public void Login()
        {
            Console.WriteLine("\nLogin to your account");
            Console.WriteLine("------------------------------");

            Console.Write("Enter username: ");
            string? username = Console.ReadLine();

            Console.Write("Enter password: ");
            string? password = Console.ReadLine();

            Validator loginValidator = new Validator();
            loginValidator.ValidateLogin(username, password);
        }

        public List<Account> LoadAccounts()
        {
            string relativePathDir = @"..\..\..\Data\";
            string relativePathFile = @"..\..\..\Data\Accounts.txt";

            if (!File.Exists(relativePathFile))
            {
                Directory.CreateDirectory(relativePathDir);
                File.Create(relativePathFile);
            }

            List<Account> accounts = new List<Account>();

            var lines = File.ReadAllLines(relativePathFile);
            foreach (string line in lines)
            {
                accounts.Add(CreateAccountFromLine(line));
            }

            return accounts;
        }

        private Account CreateAccountFromLine(string line)
        {
            var values = line.Split(',');
            return new Account { Username = values[0], Password = values[1], Role = values[2] };
        }
    }
}
