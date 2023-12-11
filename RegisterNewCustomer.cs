using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1209
{
    internal class RegisterNewCustomer
    {

        public static void RegisterCustomer(LoginSystem loginSystem)
        {
            // Skapa en temporär användare för att lägga till i användarlistan
            User newUser = new User();

            Console.WriteLine("Welcome to User Registration!");

            // Få användarnamn från användaren
            Console.Write("Enter your username: ");
            string enteredUsername = Console.ReadLine();

            // Kontrollera om användarnamnet redan finns
            if (DataManager.userList.ContainsKey(enteredUsername))
            {
                Console.WriteLine("Username already exists. Please choose a different username.");
                return; // Avsluta metoden om användarnamnet redan finns
            }

            newUser.UserName = enteredUsername;

            // Få förnamn från användaren
            Console.Write("Enter your first name: ");
            newUser.FirstName = Console.ReadLine();

            // Få efternamn från användaren
            Console.Write("Enter your last name: ");
            newUser.LastName = Console.ReadLine();

            // Få lösenord från användaren
            Console.Write("Password must contain:\n6-12 characters\nAt least one capital letter\nAt least one digit\nAt least one symbol\nEnter password: ");
            newUser.PassWord = Console.ReadLine();

            // Låt användaren välja roll
            Console.Write("Choose user role (Admin or Customer): ");
            newUser.UserRole = Console.ReadLine();

            // Antag att nextAdID är deklarerat någonstans som en statisk variabel i RegisterNewCustomer-klassen
            int nextAdID = 1;
            newUser.IDNumber = nextAdID++;

            // Lägg till den nya användaren i userList (dictionary)
            DataManager.userList.Add(newUser.UserName, newUser);

            // Visa användarinformation

            if (newUser.UserRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                AdminManager adminManager = new AdminManager(loginSystem);
                adminManager.Meny(newUser);
            }
            else if (newUser.UserRole.Equals("Customer", StringComparison.OrdinalIgnoreCase))
            {
                CustomerManager customerManager = new CustomerManager(loginSystem);
                customerManager.Meny(newUser);
            }
            else
            {
                Console.WriteLine("Invalid user role. Please choose 'Admin' or 'Customer'.");
            }
        }
    }
    //public static void AddNew()
    //{
    //    Console.WriteLine("Welcome to User Registration!");

    //    User user = new User();

    //    // Få användarnamn från användaren
    //    Console.Write("Enter your username: ");
    //    user.UserName = Console.ReadLine();

    //    // Få förnamn från användaren
    //    Console.Write("Enter your first name: ");
    //    user.FirstName = Console.ReadLine();

    //    // Få efternamn från användaren
    //    Console.Write("Enter your last name: ");
    //    user.LastName = Console.ReadLine();

    //    // Få lösenord från användaren
    //    Console.Write("Password must contain:\n6-12 characters\nAt least one capital letter\nAt least one digit\nAt least one symbol\nEnter password: ");
    //    user.PassWord = Console.ReadLine();

    //    // Låt användaren välja roll
    //    Console.Write("Choose user role (Admin or Customer): ");
    //    user.UserRole = Console.ReadLine();

    //    // Antag att nextAdID är deklarerat någonstans som en statisk variabel i RegisterNewCustomer-klassen
    //    int nextAdID = 1;
    //    user.IDNumber = nextAdID++;

    //    // Lägg till den nya användaren i userList (dictionary)
    //    DataManager.userList.Add(user.UserName, user);

    //    // Visa användarinformation
    //    Console.WriteLine($"User registered!\nUsername: {user.UserName}\nID Number:{user.IDNumber}\nFirst name: {user.FirstName}\nLast name: {user.LastName}\nPassword: {user.PassWord}\nUser Role: {user.UserRole}");
    //}

    //public static void RegisterCustomer()
    //{
    //    AddNew();

    //    // Du kanske också vill initiera rätt manager baserat på användarrollen här
    //    if (user.UserRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
    //    {
    //        AdminManager adminManager = new AdminManager();
    //        adminManager.Meny(user);
    //    }
    //    else if (user.UserRole.Equals("Customer", StringComparison.OrdinalIgnoreCase))
    //    {
    //        CustomerManager customerManager = new CustomerManager();
    //        customerManager.Meny(user);
    //    }
    //}
}
