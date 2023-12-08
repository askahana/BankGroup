using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1209
{
    class Account
    {
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string Currency { get; set; }
        public decimal Balance { get; set; }

        public Account(int accountnumber, string accountname, string currency, decimal balance)
        {
            AccountNumber = accountnumber;
            AccountName = accountname;
            Currency = currency;
            Balance = balance;
        }

    }
}
