using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1209
{
    internal interface ICustomer
    {
        
            string Email { get; set; }
            string Birthday { get; set; }
            List<Account> Accounts { get; set; }
       
    }

}
