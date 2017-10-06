using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string bin = Convert.ToString(number, 2);
            string hex = Convert.ToString(number, 16);
            Console.WriteLine(hex.ToUpper());
            Console.WriteLine(bin);
            Console.ReadLine();
        }
    }
}
