using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1209
{
    internal class CurrencyRateConverter
    {
        public static decimal FromSekToYen(decimal money) // Administrator must add the rate first.
        {
            return money * CurrencyRates.Yen;
        }
        public static decimal FromYenToSek(decimal money)
        {
            return money / CurrencyRates.Yen;
        }
        public static decimal FromSekToEur(decimal money)
        {
            return money * CurrencyRates.Euro;
        }
        public static decimal FromEurToSek(decimal money)
        {
            return money / CurrencyRates.Euro;
        }
    }
}
