using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1209
{
    internal class CustomerManager : IMeny
    {
        public void Meny(User loggedIn)
        {
            //LoginManager.LoginCheck();
            bool go = true;
            while (go)
            {
                switch (GetMenuChoice())
                {
                    case 1:
                        ShowBalance.ShowAccount(loggedIn);
                       break;
                    case 2:
                        Console.WriteLine("Out of order.");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Out of order.");
                        Console.ReadKey();
                        break;
                    case 4:
                        AccountManager.AddAccount(loggedIn);
                        Console.ReadKey();
                        break;
                    case 5:
                        CurrencyConverter.ConvertMoney(loggedIn);
                        break;
                    case 6:
                        Console.WriteLine("Out of order.");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Bye!");
                        Console.ReadKey();
                        go = false;
                        break;
                    defualt:
                        Console.Clear();
                        Console.WriteLine("Insert mellan 1-7.");
                        Console.ReadKey();
                        break;
                }
            }
        }
        public static int GetMenuChoice()
        {
            int choice;
            Console.WriteLine("Customer Meny");
            Console.WriteLine("1. View account and balance");
            Console.WriteLine("2. Transfer money between accounts");
            Console.WriteLine("3. Transfer money to other Customer");
            Console.WriteLine("4. Open new account");
            Console.WriteLine("5. Another currency");
            Console.WriteLine("6. Account history");
            Console.WriteLine("7. Logg out");
            Console.Write("Choose meny: ");
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("The number is not valid");
            }
            return choice;
        }
    }
}
