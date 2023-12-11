using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1209
{
    internal class AdminManager : IMeny
    {
        public void Meny(User loggedIn)
        {
            bool go = true;
            while (go)
            {
                Console.WriteLine("Admin Menu");
                Console.WriteLine("1. Create new user account.");
                Console.WriteLine("2. Delete user account.");
                Console.WriteLine("3. See User accounts.");
                Console.WriteLine("4. Change interest.");
                Console.WriteLine("5. Change exchange rate.");
                Console.WriteLine("6. Log out.");
                int svar = Convert.ToInt32(Console.ReadLine());
                switch (svar)
                {
                    case 1:
                        Console.WriteLine("Out of order.");
                        RegisterNewCustomer.AddNew();
                        break;
                    case 2:
                        Console.WriteLine("Out of order.");
                        Console.ReadKey();
                        break;
                    case 3:
                        ShowAllCustomer.ShowAllInfo();
                        break;
                    case 4:
                        Console.WriteLine("Out of order.");
                        Console.ReadKey();
                        break;
                    case 5:
                        CurrencyConverter.InsertRate();
                        break;
                    case 6:
                        Console.WriteLine("Out of order.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Wrong input, try again.");
                        break;
                }
            }
        }
    }
}
