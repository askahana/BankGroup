using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1209
{
    internal class ConvertManagement
    {
        public static void ConvertMoney(User loggedInUser)  // Customer will do this action. So...
        {
            if(loggedInUser is Customer customer)
            {            
                Console.WriteLine("Which account?");
                int accountNum = Validator.GetValidInt();
                foreach (Account account in customer.Accounts)
                {
                    if (account.AccountNumber == accountNum && account.Currency == "SEK")
                    {
                        Console.WriteLine("EURO");
                        Console.WriteLine(Converter.FromSekToEur(account.Balance));
                        Console.WriteLine("Yen");
                        Console.WriteLine(Converter.FromSekToYen(account.Balance));
                    }
                }
            }
        }
    }
}
