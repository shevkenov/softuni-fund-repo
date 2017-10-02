using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HW._02.ChooseDrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double sum = 0;

            switch (profession)
            {
                case "Athlete":
                    sum = quantity * 0.70;
                    Console.WriteLine($"The {profession} has to pay {sum:F2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    sum = quantity * 1;
                    Console.WriteLine($"The {profession} has to pay {sum:F2}.");
                    break;
                case "SoftUni Student":
                    sum = quantity * 1.70;
                    Console.WriteLine($"The {profession} has to pay {sum:F2}.");
                    break;
                default:
                    sum = quantity * 1.20;
                    Console.WriteLine($"The {profession} has to pay {sum:F2}.");
                    break;
            }
            Console.ReadLine();

        }
    }
}
