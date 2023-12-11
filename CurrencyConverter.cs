using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1209
{
    internal class CurrencyConverter
    {
        public static void ConvertMoney(User loggedInUser)  // Customer will do this action. So the exchange rate should be set
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
                        Console.WriteLine(CurrencyRateConverter.FromSekToEur(account.Balance));
                        Console.WriteLine("Yen");
                        Console.WriteLine(CurrencyRateConverter.FromSekToYen(account.Balance));
                    }
                }
            }
            Console.ReadKey();
        }
        public static void InsertRate() // Here administrater can change the exchange rate.
        {
            Console.WriteLine("Insert todays exchange rate.");
            Console.Write("Yen: ");
            CurrencyRates.Yen = Validator.GetValidDecimal();
            Console.Write("Euro: ");
            CurrencyRates.Euro = Validator.GetValidDecimal();
        }
    }
}
