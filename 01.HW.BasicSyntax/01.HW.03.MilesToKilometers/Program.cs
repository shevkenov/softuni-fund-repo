using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HW._03.MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var miles = double.Parse(Console.ReadLine());
            var result = miles * 1.60934;

            Console.WriteLine($"{result:F2}");
            Console.ReadLine();
        }
    }
}
