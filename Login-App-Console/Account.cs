using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_App_Console
{
    class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

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
    }
}
