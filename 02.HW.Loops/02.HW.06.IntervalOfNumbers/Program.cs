using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HW._06.IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numbrtTwo = int.Parse(Console.ReadLine());
            int maxNumber = Math.Max(numberOne, numbrtTwo);
            int minNumber = Math.Min(numberOne, numbrtTwo);

            for (int i = minNumber; i <= maxNumber; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
