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
            Console.WriteLine("Customer");
            switch (GetMenuChoice())
            {
                case 1:
                    ConvertManagement.ConvertMoney(loggedIn);
                    break;
                case 2:
                    //ShowBalance.ShowAllAccount();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                defualt:
                    Console.WriteLine("Insert mellan 1-7.");
                    break;
            }
        }

        public static int GetMenuChoice()
        {
            string menu1 = "1. Show balance in various currency";
            string menu2 = "2. ";
            string menu3 = "";
            string menu4 = "";
            Console.WriteLine(menu1);
            Console.Write("Choose: ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("The number is not valid");
                return -1;
            }
            return choice;
        }
    }
}
