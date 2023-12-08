using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1209
{
    internal class AdminManager : IMeny
    {
        public void Meny(User loggedIn)
        {
            Console.WriteLine("Admin");

            RegisterNewCustomer.AddNew();
            ShowAllCustomer.ShowAll();
            Console.ReadKey();
        }
    }
}
