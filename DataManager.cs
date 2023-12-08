using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1209
{
    internal static class DataManager
    {
        public static Dictionary<string, User> userList = new Dictionary<string, User>();
        static DataManager()
        {
            Initialize();
        }
        public static void Initialize()
        {
            User cus1 = new Customer
            {
                UserName = "cus1",
                PassWord = "Custmer!1",
                Accounts = new List<Account>
                {
                        new Account(50028977, "MainAccount", "SEK", 1234M),
                        new Account(50011265, "SavingAccount", "EUR", 1234M),
                }
            };
            User cus2 = new Customer()
            {
                UserName = "cu2",
                PassWord = "Customer!1",
                Accounts = new List<Account>
                {
                    new Account(12344556, "MainAccount", "SEK", 2345M),
                    new Account(23455678, "SavingAccount", "EUR", 2345M),
                }
            };
            User ad1 = new Admin()
            {
                UserName = "Admin1",
                PassWord = "Admin!1",
            };
            userList.Add("cus1", cus1);
            userList.Add("Admin1", ad1);
            userList.Add("cus2", cus2);
        }

    }
}
