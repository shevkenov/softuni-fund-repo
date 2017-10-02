using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HW._01.DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstDigits = int.Parse(Console.ReadLine());
            var secondDigits = int.Parse(Console.ReadLine());
            var thirdDigits = int.Parse(Console.ReadLine());
            var forthDigits = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstDigits:D4} {secondDigits:D4} {thirdDigits:D4} {forthDigits:D4}");
            Console.ReadLine();
        }
    }
}
