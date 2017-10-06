using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PracticeFloatingPointNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal doubleNumber = decimal.Parse(Console.ReadLine());
            double floatNumber = double.Parse(Console.ReadLine());
            decimal decimalNumber = decimal.Parse(Console.ReadLine());

            Console.WriteLine(doubleNumber);
            Console.WriteLine(floatNumber);
            Console.WriteLine(decimalNumber);
            Console.ReadLine();

        }
    }
}
