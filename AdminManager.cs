using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1209
{

    internal class AdminManager : IMeny
    {

        private LoginSystem loginSystem;
        private User loggedInUser;

        public AdminManager(LoginSystem loginSystem)
        {
            this.loginSystem = loginSystem;
        }

        public void Meny(User user)
        {
            loggedInUser = user;

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
                        RegisterNewCustomer.RegisterCustomer(loginSystem);
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
                        Console.WriteLine("Logging out.");
                        LogOut();
                        break;
                    default:
                        Console.WriteLine("Wrong input, try again.");
                        break;
                }
            }
        }

        private void LogOut()
        {
            Console.WriteLine("Logged out.");
            loggedInUser = loginSystem.Login();
        }





        //private LoginSystem loginSystem;
        //private User loggedInUser;

        //public AdminManager()
        //{
        //    loginSystem = new LoginSystem();
        //}

        //public void Meny(User user)
        //{
        //    loggedInUser = user;

        //    bool go = true;
        //    while (go)
        //    {
        //        Console.WriteLine("Admin Menu");
        //        Console.WriteLine("1. Create new user account.");
        //        Console.WriteLine("2. Delete user account.");
        //        Console.WriteLine("3. See User accounts.");
        //        Console.WriteLine("4. Change interest.");
        //        Console.WriteLine("5. Change exchange rate.");
        //        Console.WriteLine("6. Log out.");
        //        int svar = Convert.ToInt32(Console.ReadLine());
        //        switch (svar)
        //        {
        //            case 1:
        //                Console.WriteLine("Out of order.");
        //                RegisterNewCustomer.RegisterCustomer();
        //                break;
        //            case 2:
        //                Console.WriteLine("Out of order.");
        //                Console.ReadKey();
        //                break;
        //            case 3:
        //                ShowAllCustomer.ShowAllInfo();
        //                break;
        //            case 4:
        //                Console.WriteLine("Out of order.");
        //                Console.ReadKey();
        //                break;
        //            case 5:
        //                CurrencyConverter.InsertRate();
        //                break;
        //            case 6:
        //                Console.WriteLine("Logging out.");
        //                LogOut();
        //                break;
        //            default:
        //                Console.WriteLine("Wrong input, try again.");
        //                break;
        //        }
        //    }
        //}

        //private void LogOut()
        //{
        //    // Perform any logout actions if needed
        //    Console.WriteLine("Logged out.");

        //    // Call Login() to log in again
        //    loggedInUser = loginSystem.Login();
        //}





        //public void Meny(User loggedIn)
        //    {
        //        bool go = true;
        //        while (go)
        //        {
        //            Console.WriteLine("Admin Menu");
        //            Console.WriteLine("1. Create new user account.");
        //            Console.WriteLine("2. Delete user account.");
        //            Console.WriteLine("3. See User accounts.");
        //            Console.WriteLine("4. Change interest.");
        //            Console.WriteLine("5. Change exchange rate.");
        //            Console.WriteLine("6. Log out.");
        //            int svar = Convert.ToInt32(Console.ReadLine());
        //            switch (svar)
        //            {
        //                case 1:
        //                    Console.WriteLine("Out of order.");
        //                    RegisterNewCustomer.AddNew();
        //                    break;
        //                case 2:
        //                    Console.WriteLine("Out of order.");
        //                    Console.ReadKey();
        //                    break;
        //                case 3:
        //                    ShowAllCustomer.ShowAllInfo();
        //                    break;
        //                case 4:
        //                    Console.WriteLine("Out of order.");
        //                    Console.ReadKey();
        //                    break;
        //                case 5:
        //                    CurrencyConverter.InsertRate();
        //                    break;
        //                case 6:
        //                    Console.WriteLine("Logging out.");
        //                    go = false; // Exit the menu loop
        //                    break;
        //                default:
        //                    Console.WriteLine("Wrong input, try again.");
        //                    break;
        //            }
        //        }
        //    }
        //}
    }
}
