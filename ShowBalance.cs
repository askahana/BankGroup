using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Bank1209
{
    internal class ShowBalance          // 
    {
        public static void ShowAccount(User loggedInUser)  // This is for User.This is almost same as ConvertManagement.ConvertMoney
        {
            if (loggedInUser is Customer customer)  // If the user does not have any account yet?
            {
                Console.WriteLine("Which account?");
                int accountNum = Validator.GetValidInt();
                foreach (Account account in customer.Accounts)
                {
                    if (account.AccountNumber == accountNum)
                    {
                        Console.WriteLine($"Balance: {account.Balance}");
                    }
                    else
                    {
                       
                    }
                }
            }

        }


    }
}
