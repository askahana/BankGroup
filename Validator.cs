﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1209
{
    internal class Validator
    {
        public static int GetValidInt()
        {
            int choice;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out choice))
                    Console.WriteLine("Invalid input. Please enter an integer.");
                else
                    return choice;
            }
        }
        public static int Get1Or2()
        {
            int choice;
            int max = 0;
            while (max < 5)
            {
                max++;
                if (!int.TryParse(Console.ReadLine(), out choice))
                    Console.WriteLine("Invalid input. Please enter an integer.");
                else if (choice != 1 && 2 != choice)
                {
                    Console.WriteLine("Insert 1 or 2");
                }
                else
                    return choice;
            }
            Console.Clear();
            Console.WriteLine("You tried 5 times. Go back to menu.");
            //CustomerManager.Meny();
            Console.ReadKey();
            return 0;

        }
        public static string GetValidString()
        {
            string choice = String.Empty;
            while (String.IsNullOrEmpty(choice))
            {
                choice = Console.ReadLine();
                if (String.IsNullOrEmpty(choice))
                    Console.WriteLine("Please insert");
            }
            return choice;
        }

        public static int GetValidIntOrMenu() // This goes back to meny if the user pressed enter.
        {
            Customer cus = null;
            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                //AccountManagementSystem.Assign(Dictionary<string, User> userList);
                return 0;
            }
            else
            {
                if (int.TryParse(input, out int number))
                    return number;
                else
                {
                    Console.WriteLine("Invalid input. Please enter integer.");
                    return GetValidIntOrMenu();
                }
            }
        }
        public static decimal GetValidDecimal()
        {
            decimal money;
            while (true)
            {
                if (!decimal.TryParse(Console.ReadLine(), out money))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }
                else
                {
                    return money;
                }
            }
        }
    }
}
