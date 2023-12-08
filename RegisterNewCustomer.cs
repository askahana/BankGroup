using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1209
{
    internal class RegisterNewCustomer
    {
     public static void AddNew()
        {
            User cus4 = new Customer()
            {
                UserName = "cu4",
                PassWord = "Customer!1",
                Accounts = new List<Account>
                {
                    new Account(12344556, "MainAccount", "SEK", 2345M),
                    new Account(23455678, "SavingAccount", "EUR", 2345M),
                }
            };

            DataManager.userList.Add("cus4", cus4);
        }   
    }
}