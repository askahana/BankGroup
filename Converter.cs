using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1209
{
    internal class Converter
    {
        public static decimal Yen { get; set; }  // ca 14
        public static decimal Euro { get; set; }  // ca 0.9
        public Converter(decimal yen)
        {

        }
        public static void InsertRate() // Here administrater can change the exchange rate.
        {
            Console.WriteLine("Insert todays exchange rate.");
            Console.Write("Yen: ");
            Yen = Validator.GetValidDecimal();
            Console.Write("Euro: ");
            Euro = Validator.GetValidDecimal();
        }
        public static decimal FromSekToYen(decimal money) // Administrator must add the rate first.
        {
            if (Yen == null)                // Kanske det stämmer inte!!!
            {
                Console.WriteLine("Ask someone to insert todays rate.");
                Console.ReadKey();
                return money;
            }
            return money * Yen;
        }
        public static decimal FromYenToSek(decimal money)
        {
            return money / Yen;
        }
        public static decimal FromSekToEur(decimal money)
        {
            if (Euro == null)
            {
                Console.WriteLine("Rate has not added.");
                Console.ReadKey();
                return 0;
            }
            return money * Euro;
        }
        public static decimal FromEurToSek(decimal money)
        {
            return money / Euro;
        }
    }
}
