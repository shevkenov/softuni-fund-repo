﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HW._01.ChooseDrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            //string drinkType = Console.ReadLine();
            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine("Water");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine("Coffee");
                    break;
                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
            Console.ReadLine();

        }
    }
}
