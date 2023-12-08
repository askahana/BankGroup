using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1209
{
    internal class Customer: User
    {
        public List<Account> Accounts { get; set; }

        public Customer(){}
    }
}
